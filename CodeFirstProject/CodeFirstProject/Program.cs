using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.Write("Enter the first name of new student: ");
                var firstName = Console.ReadLine();
                Console.Write("Enter the last name of a new student: ");
                var lastName = Console.ReadLine();
               // Adding student first name and last name, id gets added automatically
                var student = new Student { FirstName = firstName, LastName = lastName };
                db.Students.Add(student);
                db.SaveChanges();
                // Displaying all students
                Console.WriteLine("A list of all students: ");
                foreach (var item in db.Students)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }    
            }
        }
    }
    // Creating a student class
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
    // Creating a derived context that allows us to query and save data from a database
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
