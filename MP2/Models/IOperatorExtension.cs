using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP2.Models
{
    public class IOperatorExtension
    {

        public static bool Operator(string logic, double x, double y)
        {
            switch (logic)
            {
                case "==": return x==y;
                case "!=": return x!=y;
                case ">": return x>y;
                case "<": return x<y;
                default: throw new ArgumentException("Illegal operator");
            }
        }

        public static bool Operator(string logic, string x, string y)
        {
            switch (logic)
            {
                case "==": return x == y;
                case "!=": return x != y;
                default: throw new ArgumentException("Illegal operator");
            }
        }
    }
}
