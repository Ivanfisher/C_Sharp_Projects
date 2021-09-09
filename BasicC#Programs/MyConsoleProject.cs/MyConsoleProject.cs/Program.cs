using System;
using System.Text;


namespace MyConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Acme Accounting Systems");
            Console.WriteLine("Remember, we're \"accounting\" on you!");
            Console.WriteLine("This assignment wants me to use string concatenation and the stringbuilder function.");
            string first = "I wrote ";
            string second = "this sentence in ";
            string third = "three different parts.";
            Console.WriteLine(first + second + third);
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is ");
            sb.Append("Ivan");
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
