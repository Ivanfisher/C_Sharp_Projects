using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please guess what my age is.");
            int age = Convert.ToInt32(Console.ReadLine());
            // Using a while loop inside of an if statement to keep having the user guess until 24 is guessed
            if (age != 24)
            {
                while (age != 24)
                {
                    Console.WriteLine("That is incorrect, please try again.");
                    age = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Great guess! 24 is correct!");
            }
            else if (age == 24)
            {
                Console.WriteLine("Great guess! 24 is correct!");
            }
            else
            {
                Console.WriteLine("Uuuummm. Something went wrong..");
            }
            Console.WriteLine("Please guess my height in inches:");
            int inches = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = inches == 71;
            // Using a do while loop to have user guess until 71 is guessed
            do
            {
                switch (inches)
                {
                    case 71:
                        Console.WriteLine("Great guess! 71 inches is correct.");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("That is incorrect. Please try again:");
                        inches = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
            Console.Read();

        }
    }
}
