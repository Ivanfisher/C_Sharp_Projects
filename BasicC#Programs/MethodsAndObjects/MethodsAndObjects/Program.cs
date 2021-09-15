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
            Employee name1 = new Employee() { FirstName = "Sample1", LastName = "Student", Id = 1 };
            Employee name2 = new Employee() { FirstName = "Sample2", LastName = "Student", Id = 2 };


            Console.WriteLine(name1 != name2);
            // Calling SayName method. Method prints out full name
            name1.SayName();
            Console.Read();
        }
    }
}
