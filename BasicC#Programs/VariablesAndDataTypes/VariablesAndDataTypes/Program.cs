using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number.");
            long multiplication = Convert.ToInt64(Console.ReadLine()) * 50;
            Console.WriteLine(multiplication);
            Console.WriteLine("Please enter any integer less than 2 million.");
            int addittion = Convert.ToInt32(Console.ReadLine()) + 25;
            Console.WriteLine(addittion);
            Console.WriteLine("Please enter any integer less than 2 million.");
            double division = Convert.ToDouble(Console.ReadLine()) / 12.5;
            Console.WriteLine(division);
            Console.WriteLine("Please enter any integer less than 2 million.");
            int remainder = Convert.ToInt32(Console.ReadLine()) % 7;
            Console.WriteLine(remainder);
            Console.Read();
        }
    }
}
