using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AbstractClass
{
    public class Employee : Person, IQuittable
    {
        // Implementing SayName 
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        // Implementing Quit method
        public void Quit()
        {
            Console.WriteLine("Program will quit in 5 seconds.");
            // Using thread.Sleep to halt program for 5 seconds
            Thread.Sleep(5000);
            // Using Environment.Exit to end program
            Environment.Exit(0);


        }
    }
}
