using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current day of the week?");
            bool isValid = false;

            // Using a while loop to keep prompting user for current day until valid input is given
            while (!isValid)
            {
                // Using try/catch block. Code inside of try block is executed unless error is thrown then code in catch block is exucuted
                try
                {
                    //WeekDays day = new WeekDays();
                    // Checking to see if user input is one the days of the week if true, assigning it to variable today
                    WeekDays.DaysOfWeek today = (WeekDays.DaysOfWeek)Enum.Parse(typeof(WeekDays.DaysOfWeek), Console.ReadLine());
                    Console.WriteLine(today);
                    // Setting isValid to true to exit while loop
                    isValid = true;
                }
                catch (Exception)
                {

                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
                
            Console.Read();
        }
    }
}
