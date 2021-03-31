using System;

namespace MP2.Models
{
    public class Attribute
    {
        public string name;
        public dynamic value;
        public Type type;


        public Attribute(string name, string value)
        {
            this.name = name;
            TryParseDouble(value);
        }

        private void TryParseDouble(string parameter)
        {
            
            try
            {
                var value = Convert.ChangeType(parameter, typeof(double));
                if (value == null) throw new Exception("Empty value");
                type = typeof(double);
                this.value = value;
            }
            catch
            {
                type = typeof(string);
                value = parameter;
            }
        }
    }
}
