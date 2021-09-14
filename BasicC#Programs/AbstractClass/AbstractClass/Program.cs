using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating new object "name" and initializing it with FirstName value "Sample" and LastName value "Student"
            Employee name = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Calling SayName method. method prints out full name
            name.SayName();
            Console.Read();
        }
    }
}
