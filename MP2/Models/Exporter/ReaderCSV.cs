using Exporter.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Exporter.Models
{
    class ReaderCSV : IReaderCSV, IDisposable
    {
        private IParserCSV _parser;
        private string[] _headers;

        private bool _isDisposed;

        public ReaderCSV(IParserCSV parser)
        {
            _parser = parser;
            _headers = _parser.ParseLine(0);
        }

        public ReaderCSV(IParserCSV parser, params string[] headers)
        {
            _parser = parser;
            _headers = headers;
        }

        public string[] GetHeaders()
        {
            return _headers;
        }

        public T[] ReadToEnd<T>(bool includeNullValues = false)
        {
            List<T> returnArr = new List<T>();
            foreach (var argsArr in _parser.ParseToEnd2D())
            {
                T @object = ConvertGivenData<T>(argsArr);
                if (@object != null || includeNullValues) returnArr.Add(@object);
            }
            return returnArr.ToArray();
        }

        public T ReadLine<T>()
        {
            var data = _parser.ParseLine();
            var item = ConvertGivenData<T>(data);
            if (item != null) return item;
            return ReadLine<T>();
        }

        public async Task<T> ReadLineAsync<T>()
        {
            var data = await _parser.ParseLineAsync();
            var item = ConvertGivenData<T>(data);
            if (item != null) return item;
            return await ReadLineAsync<T>();
        }

        public T ReadLine<T>(int index)
        {
            var data = _parser.ParseLine(index);
            return ConvertGivenData<T>(data);
        }

        private T ConvertGivenData<T>(string[] line)
        {
            if (line.SequenceEqual(_headers)) return default;
            
            string[] parsedLine = line;
            if (parsedLine.Length != _headers.Length) return default;
            int elementPosition = 0;
            object[] args = new object[_headers.Length];

            ConstructorInfo constructorInfo = FindCorrectConstructorForGivenHeaders<T>(_headers);
            if (constructorInfo.GetParameters()[0].ParameterType == typeof(string[]) && constructorInfo.GetParameters().Length == 1)
            {
                return (T)Activator.CreateInstance(typeof(T), line);
            }



            foreach (var element in parsedLine)
            {
                if (element == string.Empty) return default;

                int paramPosition = -1;
                
                foreach (var param in constructorInfo.GetParameters())
                {
                    if (param.Name == _headers[elementPosition])
                    {
                        paramPosition = param.Position;
                        break;
                    }
                    
                }

                try
                {
                    var type = constructorInfo.GetParameters()[paramPosition].ParameterType;

                    if (type == typeof(int)) args[paramPosition] = Convert.ChangeType(element, typeof(int));
                    else if (type == typeof(string)) args[paramPosition] = Convert.ChangeType(element, typeof(string));
                    else if (type == typeof(DateTime)) args[paramPosition] = Convert.ChangeType(element, typeof(DateTime));
                    else if (type == typeof(double)) args[paramPosition] = Convert.ChangeType(element, typeof(double));
                }
                catch (Exception e)
                {
                    throw e;
                }
                elementPosition++;
            }

            return (T)Activator.CreateInstance(typeof(T), args);
        }

        private ConstructorInfo FindCorrectConstructorForGivenHeaders<T>(string[] input)
        {
            Exception exc;
            if(input.Length != input.Distinct().Count())
            {
                exc = new ArgumentException("Duplicates in header names are not allowed");
                throw exc;
            }

            var paramsCount = input.Length;
            BindingFlags constrFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance;

            foreach (var constructor in typeof(T).GetConstructors(constrFlags))
            {
                bool isCorrectConstructor = true;
                var constructorParams = constructor.GetParameters();
                if(constructorParams[0].ParameterType == typeof(string[]) && constructorParams.Length==1) return constructor;

                

                if (constructorParams.Length != paramsCount) continue;

                foreach (var param in constructorParams)
                {
                    string parName = param.Name;
                    if (!input.Contains(parName))
                    {
                        isCorrectConstructor = false;
                        break;
                    }
                }

                if (isCorrectConstructor) return constructor;
            }

            exc = new ArgumentException("No matching constructor found for submitted headers");
            throw exc;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                try
                {
                    if (disposing && (_parser != null))
                    {
                        _parser.Dispose();
                    }

                    if (_parser != null) _parser = null;
                }
                finally
                {
                    _headers = null;
                    _isDisposed = true;
                }
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

    }
}
