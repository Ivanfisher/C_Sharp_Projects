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
            // Using boolean logic to determine if user is qualified for insurance then printing it to console
            Console.WriteLine("Are you qualified?\n" + (age > 15 && dui == false && tickets < 4));
            Console.Read();
        }
    }
}
