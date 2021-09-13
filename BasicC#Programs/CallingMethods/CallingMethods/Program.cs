using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to perform math operations on:");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(int1 + " cubed is " + MathOperations.InputCubed(int1));
            if (MathOperations.InputRemainder(int1) == 0)
            {
                Console.WriteLine(int1 + " is divisible by 6. The quotient is " + MathOperations.InputQuotient(int1) + " and the remainder is " + MathOperations.InputRemainder(int1) + ".");
            }
            else
            {
                Console.WriteLine(int1 + " is not evenly divisible by six. The quotient is " + MathOperations.InputQuotient(int1) + " and the remainder is " + MathOperations.InputRemainder(int1) + ".");
            }
            Console.Read();
        }
    }
}
