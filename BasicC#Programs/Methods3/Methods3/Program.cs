using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps mathOps = new MathOps();
            Console.WriteLine("Please enter an integer:");
            int int1 = Convert.ToInt32(Console.ReadLine());
            // Calling Math1 method in MathOps class. Method divides user input by 2 then prints result to console
            mathOps.Math1(int1);


            // Declaring variables a and b then initializing them with parameter out values from Math1 function then prints results to console
            int a, b;
            mathOps.Math1(out a, out b);
            Console.WriteLine(a + ", " + b);

            
            // Calling Addition function in static StaticClass class then printing result to console. (function adds 10 to input)
            Console.WriteLine(StaticClass.Addition(5));
            Console.Read();
        }
    }
}
