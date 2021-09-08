using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will ask some questions to determine if you are qualified for car insurance.");
            Console.WriteLine("What is your age?");
            // Converting user input to integer then assigning it to variable called age
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
            Console.WriteLine("Please enter true or false for this question. Have you ever had a DUI?");
            // Converting user input to boolean then assigning it to variable called dui
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(dui);
            Console.WriteLine("How many speeding tickets do you have?");
            // Converting user input to integer then assigning it to variable called tickets
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(tickets);
            if (age > 15 && dui == false && tickets < 4)
            {
                Console.WriteLine("Congratulations! You qualify for insurance!");
            }
            else if (age <= 15)
            {
                Console.WriteLine("Sorry, you are too young for insurance.");
            }
            else if (dui != false)
            {
                Console.WriteLine("Sorry, we can't give you insurance because of your DUI offense.");
            }
            else if (tickets > 3)
            {
                Console.WriteLine("Sorry, we can't give you insurance due to your ticket record.");
            }
            else
            {
                Console.WriteLine("Sorry, not sure what happened. Please try again.");
            }
            Console.Read();
        }
    }
}
