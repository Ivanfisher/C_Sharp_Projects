using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // Creating an abstract class
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Creating a method that prints out full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
