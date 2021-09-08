using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Please enter the following details for person 1,");
            Console.WriteLine("Hourly rate: ");
            double p1HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            double p1HoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the following details for person 1,");
            Console.WriteLine("Hourly rate: ");
            double p2HourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            double p2HoursWorked = Convert.ToDouble(Console.ReadLine());
            double p1AnnualSalary = p1HourlyRate * p1HoursWorked * 52;
            double p2AnnualSalary = p2HourlyRate * p2HoursWorked * 52;
            bool moreIncome = p1AnnualSalary > p2AnnualSalary;
            Console.WriteLine("Annual salary of Person 1:\n$" + p1AnnualSalary);
            Console.WriteLine("Annual salary of Person 2:\n$" + p2AnnualSalary);
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + moreIncome);
            Console.Read();
        }
    }
}
