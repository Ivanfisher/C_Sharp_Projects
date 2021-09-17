using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        // Chaining this constructor to another constructor
        public Person(string name) : this(name, 0)
        {
            Name = name;
        }
        // Creating a constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
