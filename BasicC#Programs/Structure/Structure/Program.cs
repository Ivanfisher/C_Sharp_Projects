using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 45 };
            Console.WriteLine(number.Amount);
            Console.Read();
        }
    }
}
