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
            // Creating and instantiating a list of employees with 10 employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { FirstName = "John", LastName = "Ball", Id = 1 },
                new Employee() { FirstName = "Joe", LastName = "Strauss", Id = 2 },
                new Employee() { FirstName = "Lily", LastName = "Berger", Id = 3 },
                new Employee() { FirstName = "Joe", LastName = "Dixon", Id = 4 },
                new Employee() { FirstName = "Marilyn", LastName = "Polk", Id = 5 },
                new Employee() { FirstName = "Brittany", LastName = "Kling", Id = 6 },
                new Employee() { FirstName = "Adam", LastName = "Trexler", Id = 7 },
                new Employee() { FirstName = "Alvero", LastName = "Baez", Id = 8 },
                new Employee() { FirstName = "Joe", LastName = "Miller", Id = 9 },
                new Employee() { FirstName = "Olivia", LastName = "Lambert", Id = 10 },
            };


            // Creating a new list for employees with first name "Joe"
            List<Employee> NameJoe1 = new List<Employee>();
            // Using a foreach loop to add all employees with first name "Joe" to NameJoe1 list
            foreach (Employee employee in employees)
            {
                // Writing out entire list to console
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Id);
                if (employee.FirstName == "Joe")
                {
                    NameJoe1.Add(employee);
                }
            }


            // Creating a new list with all employees with first name "Joe" with a lambda expression
            List<Employee> NameJoe2 = employees.Where(x => x.FirstName == "Joe").ToList();


            // Creating a new list with all employees that have an Id that is greater than five
            List<Employee> IdFiveUp = employees.Where(x => x.Id > 5).ToList();


            //--- REST OF CODE WAS FOR AN EARLIER ASSIGNMENT. I JUST COMMENTED THIS OUT FOR NOW --

            //employees.Add(new Employee() { FirstName = "Joe", LastName = "Hoffman", Id = 1 },
            //new Employee() { FirstName = "John", LastName = "Doe", Id = 2 });
            //// Instantiating new object "name1" and initilizing it with FirstName value "Sample1" and LastName value "Student" and Id "1"
            //Employee name1 = new Employee() { FirstName = "Sample1", LastName = "Student", Id = 1 };
            //// Instantiating new object "name2" and initilizing it with FirstName value "Sample2" and LastName value "Student" and Id "2"
            //Employee name2 = new Employee() { FirstName = "Sample2", LastName = "Student", Id = 2 };


            //// When == is used on Employee objects it checks to see if objects id are equal. Printing result to console
            //Console.WriteLine(name1 == name2);

            //// Calling SayName method. Method prints out full name
            //name1.SayName();
            Console.Read();
        }
    }
}
