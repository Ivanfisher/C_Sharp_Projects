using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating two new instances of class Person
            Person person1 = new Person("Mark");
            Person person2 = new Person("Landon", 28);
            // Creating a constant string
            const string name = "Ivan Fisher";
            // Creating an int variable with "var"
            var age = 24;
            Console.WriteLine(person2);
            Console.Read();
        }
    }
}
