using System;
using System.Collections.Generic;

namespace MP2.Models
{
    public class UniversalObject
    {

        public Dictionary<string,string> StringValues { get; private set; }
        public Dictionary<string,double> DoubleValues { get; private set; }

        private readonly string[] @params;
        private readonly string[] _headers;

        public UniversalObject(string[] headers, params string[] parameters)
        {
            @params = parameters;
            _headers = headers;
            DoubleValues = new Dictionary<string, double>();
            StringValues = new Dictionary<string, string>();
            Initialize();
        }

        private void Initialize()
        {
            for(int i=0; i<@params.Length; i++)
            {
                var item = @params[i];
                try
                {
                    var value = Convert.ChangeType(item, typeof(double));
                    if (value == null) throw new Exception("Empty value");
                    DoubleValues.Add(_headers[i], (double)value);
                }
                catch
                {
                    StringValues.Add(_headers[i], item);
                }
            }
        }

        public override string ToString()
        {
            string returnString = "";
           
            for(int i=0; i<_headers.Length; i++)
            {
                DoubleValues.TryGetValue(_headers[i], out double valueDouble);
                StringValues.TryGetValue(_headers[i], out string valueString);

                if (valueDouble != default) returnString += valueDouble;
                else if (valueString != default) returnString += valueString;

                if (i != _headers.Length - 1) returnString += " | ";
            }

            return returnString;
            //return string.Join(" | ", StringValues.Values)+ " | " + string.Join(" | ", DoubleValues.Values);
        }
    }
}
