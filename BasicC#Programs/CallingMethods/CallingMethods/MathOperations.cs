using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class MathOperations
    {
        public static int InputCubed(int int1)
        {
            int1 = Convert.ToInt32(Math.Pow(int1, 3));
            return int1;
        }

        public static int InputQuotient(int int1)
        {
            int1 = int1 / 6;
            return int1;
        }

        public static int InputRemainder(int int1)
        {
            int1 = int1 % 6;
            return int1;
        }
    }
    
}
