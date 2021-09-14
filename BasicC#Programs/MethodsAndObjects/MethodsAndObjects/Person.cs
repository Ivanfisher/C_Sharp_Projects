using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
        // Assigning two properties to Person class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Creating SayName function that simply prints to console the full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
