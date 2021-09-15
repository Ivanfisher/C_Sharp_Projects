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
            // Instantiating new object "name1" and initilizing it with FirstName value "Sample1" and LastName value "Student" and Id "1"
            Employee name1 = new Employee() { FirstName = "Sample1", LastName = "Student", Id = 1 };
            // Instantiating new object "name2" and initilizing it with FirstName value "Sample2" and LastName value "Student" and Id "2"
            Employee name2 = new Employee() { FirstName = "Sample2", LastName = "Student", Id = 2 };


            // When == is used on Employee objects it checks to see if objects id are equal. Printing result to console
            Console.WriteLine(name1 == name2);

            // Calling SayName method. Method prints out full name
            name1.SayName();
            Console.Read();
        }
    }
}
