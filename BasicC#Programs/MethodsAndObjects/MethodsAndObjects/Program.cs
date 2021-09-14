using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating new object "name" and initilizing it with FirstName value "Sample" and LastName value "Student"
            Employee name = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Calling SayName method. Method prints out full name
            name.SayName();
            Console.Read();
        }
    }
}
