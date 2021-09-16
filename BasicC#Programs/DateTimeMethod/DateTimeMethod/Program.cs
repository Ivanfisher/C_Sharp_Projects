using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writing the current time to the console
            Console.WriteLine(DateTime.Now);
            Console.Write("Please enter an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            // Writing to the console what time it will be in the amount of hours the user has entered
            // DateTime.Now.AddHours(input) adds input (and integer user has entered) to the hours of the current time
            Console.WriteLine("In {0} hours, it will be {1}.", input, DateTime.Now.AddHours(input));
            Console.Read();
        }
    }
}
