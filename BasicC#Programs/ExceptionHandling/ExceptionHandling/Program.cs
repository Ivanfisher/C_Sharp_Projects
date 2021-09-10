using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using a try/catch block to handle errors by the user
            try
            {
                List<int> dividends = new List<int> { 48, 59, 32, 90, 5082, -54 };
                Console.WriteLine("Please enter a number to divide a list of numbers by:");
                int divisor = Convert.ToInt32(Console.ReadLine());
                // Using a for loop to divide and then print out the integers in the list one at a time
                for (int i = 0; i < dividends.Count(); i++)
                {
                    Console.WriteLine(dividends[i] + " divided by " + divisor + " equals " + (dividends[i] / divisor) + " rounded down.");
                }
            }
            // Using Exception to catch all errors then assigning the error message to variable ex
            catch (Exception ex)
            {
                // Displaying error message
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program has emerged from try/catch block and continued on..");
            Console.Read();
        }
    }
}
