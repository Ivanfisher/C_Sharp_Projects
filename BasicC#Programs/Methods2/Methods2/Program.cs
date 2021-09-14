using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the method. Math1 just performs a simple math operation on parameter 1 and displays parameter two to the screen
            MathOps.Math1(21, 456);
            // Calling the method and specifying the parameters by name
            MathOps.Math1(int2: -43, int1:-7);
            Console.Read();
        }
    }
}
