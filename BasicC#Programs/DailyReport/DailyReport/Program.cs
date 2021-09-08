using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            // Asking user for name then storing it in string called studentName
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            // Asking user which course they're on then storing it variable called course
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            // Asking user which page number they're on then converting string answer into integer and storing it in variable called pageNumber
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            // Asking user if they need help with anything then converting string answer into boolean and storing it in variable called needHelp
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            // Asking user to share positive experiences then storing answer in variable called experiences
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            string experiences = Console.ReadLine();
            // Asking user for any other feedback then storing answer in variable called feedback
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string feedback = Console.ReadLine();
            // Asking user for number of hours studied today then converting string answer to an integer and storing it in variable called studyHours
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
