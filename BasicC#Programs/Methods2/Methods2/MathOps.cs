using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class MathOps
    {
        // Creating a simple method that does a simple math operation on parameter 1 and writes parameter two to the console. Returns no value.
        public static void Math1(int int1, int int2)
        {
            int1 = Convert.ToInt32(Math.Pow(int1, 4));
            Console.WriteLine(int2);
        }
    }
}
