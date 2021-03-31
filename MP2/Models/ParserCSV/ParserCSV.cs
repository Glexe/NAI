using Exporter.Models.Common;
using System;
using System.IO;
using System.Linq;

namespace Exporter.Models
{
    class ParserCSV : IParserCSV, IDisposable
    {
        private readonly string _filePath;

        private static StreamReader _reader;
        private readonly char _delimiter;
        private bool _isDisposed;
        private string[] _headers;

        public ParserCSV(string filePath, char delimiter = ',')
        {
            _filePath = filePath;
            _reader = new StreamReader(filePath);
            _delimiter = delimiter;
            var headers = ParseHeaders();
            if (headers is null) throw new NullReferenceException("File is empty");
            _headers = headers;
        }

        public string[] ParseHeaders()
        {
            if (_headers != null) return _headers;
            _headers = ParseLine(0);
            return _headers;
        }
        public string[] ParseLine()
        {
            var line = _reader.ReadLine();
            if (line is null) return null;
            var words = line.Split(_delimiter).Select(item => item.Trim()).ToArray();
            if (words.SequenceEqual(_headers)) words = ParseLine();

            return words;
        }
        public string[] ParseLine(int index) 
        {
            var reader = new StreamReader(_filePath);

            var line = reader.ReadLine();
            if (line is null) return null;

            for (int i=0; i< index; i++)
            {
                reader.ReadLine();
            }

            string[] words = line.Split(_delimiter).Select(item => item.Trim()).ToArray();
            return words;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                try
                {
                    if (disposing && (_reader != null))
                    {
                        _reader.Close();
                    }

                    if (_reader != null) _reader = null;
                }
                finally
                {
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
