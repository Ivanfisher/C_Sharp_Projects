using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class MathOperations
    {
        public int Int1 { get; set; }
        public decimal Decimal1 { get; set; }
        public string String1 { get; set; }

        // Creating a method that takes an integer parameter then returns the value of the argument times 5
        public int Math1(int Int1)
        {
            return Int1 * 5;
        }

        // Creating a method that takes decimal parameter then returns the value of the argument plus 34 
        public decimal Math1(decimal Decimal1)
        {
            
            return Math.Round(Decimal1 * 7.25m);
        }

        // Creating a method that takes an integer parameter then returns the value of the argument times 5
        public string Math1(string String1)
        {
            int x = Convert.ToInt32(String1) + 30;
            return x.ToString();
        }
    }
    
}
