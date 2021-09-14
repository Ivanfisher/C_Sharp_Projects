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
            Console.WriteLine("Please enter one or two integers, one at a time. Second integer is optional.");
            // Storing first user input in variable called int1
            int int1 = Convert.ToInt32(Console.ReadLine());
            // Declaring a variable but not initializing it yet
            int int2;
            // Using int.TryParse method to determine if user second input is a valid integer. If true, input is stored in variable called int2
            bool isInt = int.TryParse(Console.ReadLine(), out int2);
            // If isInt is false, execute code in if block, else if isInt is true, execute code in else block
            if (!isInt)
            {
                // MathOperations.Math1 takes 1 parameter and an optional second parameter. Method adds 52 to first parameter and multiplies sum with second parameter
                // Second parameter default value is 1
                Console.WriteLine(int1 + " plus 52 equals " + MathOperations.Math1(int1) + ".");
            }
            else
            {
                Console.WriteLine(int1 + " plus 52 times " + int2 + " equals " + MathOperations.Math1(int1, int2) + ".");
            }
            
            Console.Read();
        }
    }
}
