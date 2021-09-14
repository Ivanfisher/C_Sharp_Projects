using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class MathOperations
    {
        // Creating method that takes in at least one parameter with optional second parameter
        public static int Math1(int int1, int int2 = 1)
        {
            return (int1 + 52) * int2;
        }
    }
    
}
