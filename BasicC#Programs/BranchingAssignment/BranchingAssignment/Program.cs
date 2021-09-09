using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package you want to send.");
            double weight = Convert.ToDouble(Console.ReadLine());
            // If weight is more than less than or equal to 50 program executes content inside of if statement,
            // else program executes else then quits.
            if (weight <= 50)
            {
                // Asking user for dimension values then storing them in variables
                Console.WriteLine("Please enter the width of the package.");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the height of the package.");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the length of the package.");
                double length = Convert.ToDouble(Console.ReadLine());
                // If the sum of the dimensions equal 50 or less then code inside of if statement executes,
                // else program executes else then quits.
                if ((height + width + length) <= 50)
                {
                    // Determining quote for package
                    double quote = width * height * length * weight / 100;
                    // Printing out what quote is and using String.Format to ensure no more or less than two digits after decimal point
                    Console.WriteLine("Your estimated total for shipping this package is: $" + String.Format("{0:0.00}", quote) + "\nThank you!");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.Read();
        }
    }
}
