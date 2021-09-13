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
            MathOperations MathOps = new MathOperations();
            Console.WriteLine("Please enter an integer.");
            // Creating an instance of class MathOperations
            MathOps.Int1 = Convert.ToInt32(Console.ReadLine());
            // Math1(int) method multiplies input by 5. Printing out result to console
            Console.WriteLine(MathOps.Int1 + " times 5 equals " + MathOps.Math1(MathOps.Int1) + ".");


            Console.WriteLine("Please enter a decimal number.");
            // Creating an instance of class MathOperations
            MathOps.Decimal1 = Convert.ToDecimal(Console.ReadLine());
            // Math1(decimal) method multiplies input by 7.25 then rounds to the nearest whole number. Printing out result to console
            Console.WriteLine(MathOps.Decimal1 + " times 7.25 rounded to the nearest whole number equals " + MathOps.Math1(MathOps.Decimal1) + ".");


            Console.WriteLine("Please enter an integer.");
            // Creating an instance of class MathOperations
            MathOps.String1 = Console.ReadLine();
            // Math1(string) method adds 30 to input (if input is convertible to integer). Printing out results to console
            Console.WriteLine(MathOps.String1 + " plus 30 equals " + MathOps.Math1(String1: MathOps.String1) + ".");


            Console.Read();
        }
    }
}
