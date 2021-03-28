using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MP2.Models
{
    class TrainObject
    {
        public List<double> DoubleValues { get; private set; }
        public List<string> StringValues { get; private set; }

        public Dictionary<string,string> StringVal { get; private set; }
        public Dictionary<string,double> DoubleVal { get; private set; }

        private readonly string[] @params;

        public TrainObject(params string[] parameters)
        {
            @params = parameters;
            DoubleValues = new List<double>();
            StringValues = new List<string>();
            Initialize();
        }

        private void Initialize()
        {
            foreach(var item in @params)
            {
                try
                {
                    var value = Convert.ChangeType(item, typeof(double));
                    if (value == null) throw new Exception("Empty value");
                    DoubleValues.Add((double)value);
                }
                catch
                {
                    StringValues.Add(item);
                }
            }
        }

        public override string ToString()
        {
            return string.Join(",", DoubleValues)+ " " + string.Join(",", StringValues);
        }
    }
}
