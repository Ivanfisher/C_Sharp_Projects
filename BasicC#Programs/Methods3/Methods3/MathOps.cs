using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class MathOps
    {
        // Creating a Math1 method that takes in one parameter, divides it by two, then prints out result to console
        public void Math1(int int1)
        {
            Console.WriteLine(int1 / 2);
        }


        // Overloading a parameter by using same name. Also creating method with output parameters
        public void Math1(out int x, out int y)
        {
            Console.WriteLine("Please enter an integer:");
            x = (Convert.ToInt32(Console.ReadLine()) + (-21)) * 4;
            Console.WriteLine("Please a second integer:");
            y = (Convert.ToInt32(Console.ReadLine()) - 5) * x;
        }
    }
}
