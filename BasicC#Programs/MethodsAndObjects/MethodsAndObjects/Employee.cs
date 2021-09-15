using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    // Creating another class that inherits the properties of class Person
    class Employee : Person
    {
        // Assigning another property to Employee class
        public int Id { get; set; }


        // Overloading == operator so it checks if input1 id is equal to input2 id, returns true or false
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return Equals(emp1.Id, emp2.Id);
        }

        // Overloading != operator so it checks if input1 id is equal to input2 id, returns true or false
        // I have to define != if I overload == ..
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(Equals(emp1, emp2));
        }
    }
}
