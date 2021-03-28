using Exporter.Models.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Exporter.Models
{
    class ParserCSV : IParserCSV, IDisposable
    {
        private readonly string _filePath;

        private static StreamReader _reader;
        private readonly char _delimiter;
        private bool _isDisposed;

        public ParserCSV(string filePath, char delimiter = ',')
        {
            _filePath = filePath;
            _reader = new StreamReader(filePath);
            _delimiter = delimiter;
        }

        public string[] ParseLine()
        {
            var line = _reader.ReadLine();
            if (line is null) return null;

            string[] words = line.Split(_delimiter).Select(item => item.Trim()).ToArray();
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

        public async Task<string[]> ParseLineAsync()
        {
            string line = await _reader.ReadLineAsync();
            string[] words = line.Split(_delimiter);
            Array.ForEach(words, s => s.Trim());

            return words;
        }

        public string[] ParseToEnd()
        {
            string[] words = _reader.ReadToEnd().Split(_delimiter);
            Array.ForEach(words, s => s.Trim());

            return words;
        }  
        
        public string[][] ParseToEnd2D()
        {
            List<string[]> returnArr = new List<string[]>();
            string[] tmpArr;

            while((tmpArr = ParseLine()) != null)
            {
                returnArr.Add(tmpArr);
            }

            return returnArr.ToArray();
        }

        public async Task<string[][]> ParseToEnd2DAsync()
        {
            List<string[]> returnArr = new List<string[]>();
            string[] tmpArr;

            while ((tmpArr = await ParseLineAsync()) != null)
            {
                returnArr.Add(tmpArr);
            }

            return returnArr.ToArray();
        }

        public string ParseWord(char delimiter)
        {
            string word;
            uint charsCount = 0;
            int @char;
            AllocateBuffer(out char[] wordCharsBuffer);
            while((@char = _reader.Read()) != -1 && @char != delimiter && @char != '\n' && @char != '\r')
            {
                AppendToBuffer(ref wordCharsBuffer, ref charsCount, (char)@char);
            }

            word = charsCount == 0 ? null : new string(wordCharsBuffer);
            return word;
        }

        public string ParseWord()
        {
            return ParseWord(_delimiter);
        }

        private void AllocateBuffer(out char[] buffer, uint bufferSize = 256)
        {
            if(bufferSize <= 0)
            {
                var exc = new ArgumentException("Buffer size can't be zero");
                throw exc;
            }
            buffer = new char[bufferSize];
        }

        private void ResizeBuffer(ref char[] buffer)
        {
            try
            {
                char[] tmpArr = new char[buffer.Length * 2];
                Array.Copy(buffer, tmpArr, buffer.Length);
                buffer = tmpArr;
            }catch(Exception)
            {
                var exc = new ArgumentNullException("Given buffer can't be NULL");
                throw exc;
            }
        }

        private void AppendToBuffer(ref char[] buffer, ref uint indexer, char value)
        {

            if (buffer == null) AllocateBuffer(out buffer);

            if (indexer < buffer.Length)
            {
                buffer[indexer] = value;
                indexer++;
            }
            else
            {
                ResizeBuffer(ref buffer);
                AppendToBuffer(ref buffer, ref indexer, value);
            }
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
