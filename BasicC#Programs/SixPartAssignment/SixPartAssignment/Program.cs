using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is for part one assignment
            string[] stringArray = { "Jon", "Valerie", "Sarah", "Kayla", "Marcus", "Javier" };
            Console.WriteLine("please enter a last name:");
            string lastName = Console.ReadLine();
            // Using a for loop to add to each name the last name that the user entered
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + " " + lastName;
            }
            // Using a for loop to print out each name
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }



            // Tis is for part two assignment
            // For this assignment I was supposed to create an infinite loop then fix it
            // To do that, I made i decrement each time, then to fix it I switched it to make i increment each time
            int infinite = 10;
            for (int i = 0; i < infinite; i++)
            {
                Console.WriteLine(i);
            }



            // This is for part three assignment
            int int1 = 12;
            // This for loop uses the less than operator to determine wether to continue iterating through the loop
            for (int i = 0; i < int1; i++)
            {
                Console.WriteLine(i);
            }

            int int2 = 12;
            // This for loop uses the less than or equal to operator to determine wether to continue iteration through the loop
            for (int i = 0; i <= int2; i++)
            {
                Console.WriteLine(i);
            }



            // This is for part four assignment
            List<string> fruits = new List<string> { "apple", "orange", "banana", "kiwi", "strawberry", "blueberry", "mango" };
            Console.WriteLine("please enter a common fruit name:");
            string inputFruit = Console.ReadLine();
            bool isValid = false;
            // Using a while to loop to continue doing the foreach loop until valid input is given
            while (isValid == false)
            {
                // Using foreach loop to check if input matches an item in list
                foreach (string fruit in fruits)
                {
                    // Checking if input (converted input to everything lowercase) matches an item in list
                    if (fruit == inputFruit.ToLower())
                    {
                        // Writing out which index user input is in. 
                        // Utilizing .first().tostring.toupper to capitlize first letter and .substring to make rest of word lowercase
                        Console.WriteLine(inputFruit.First().ToString().ToUpper() + inputFruit.Substring(1).ToLower() + " is in index " + fruits.IndexOf(fruit) + ".");
                        // Setting variable isvalid to true to exit while loop
                        isValid = true;
                    }
                }
                // Prints out content in if statement if user input does not equal an item in list
                if (isValid == false)
                {
                    Console.WriteLine(inputFruit + " is not on the list of fruits. please try again:");
                    inputFruit = Console.ReadLine();
                }
            }



            // This is for part five assignment. It does what it's supposed to do but  I'm thinking there might be a better way??
            List<string> workers = new List<string> { "Jasmine", "Brianna", "Jane", "Arnold", "Allen", "Andrea", "James", "Brianna", "James" };
            Console.WriteLine("Please a worker name from Acme Accounting.");
            string inputName = Console.ReadLine();
            string workerIndex = "";
            bool validName = false;
            // Using a while loop to keep doing for loop until user input is valid
            while (validName == false)
            {
                // Using a for loop to iterate through the list to see if input matches any item in list
                for (int i = 0; i < workers.Count; i++)
                {
                    if (workers[i] == inputName)
                    {
                        // Adding the index of matched name to a variable if match if the first one
                        if (workerIndex.Length < 1)
                        {
                            workerIndex = Convert.ToString(i);
                            validName = true;
                        }
                        // Concatenating 2nd index to variable if user input already has a prior match in list
                        else
                        {
                            workerIndex = workerIndex + ", " + Convert.ToString(i);
                        }
                    }
                }
                // Asking user for another input if previous input didn't match any items in list
                if (validName == false)
                {
                    Console.WriteLine(inputName + " is not on the list of workers. Please try again:");
                    inputName = Console.ReadLine();
                }

                else
                {
                    // Printing out content in if statement if only one match has been found in list
                    if (workerIndex.Length < 2)
                    {
                        Console.WriteLine(inputName + " is in index " + workerIndex);
                    }
                    // Printing out content in else statement if more than one match has been found in list
                    else
                    {
                        Console.WriteLine(inputName + " is in the following indices: " + workerIndex);
                    }
                }
            }


            // This is for part six assignment. Again, it does what it's supposed to but not sure if there is a better way??
            List<string> customers = new List<string> { "Avery", "Scott", "Julio", "Madison", "Avery", "Aliza", "Milan", "Julio" };
            List<string> customerNames = new List<string>();
            foreach (string customer in customers)
            {
                // Using .Contains to see if customer that loop is currently checking is in oneCustomer List. If true, execute code in if block
                if (customerNames.Contains(customer))
                {
                    Console.WriteLine(customer + ".  " + customer + " has appeared previously in this list.");
                }
                // Executing code in else block if customer name is not already in oneCustomer list
                else
                {
                    customerNames.Add(customer);
                    Console.WriteLine(customer + ".  " + customer + " has not appeared previously in this list.");
                }
            }
            customerNames.Clear();
            Console.Read();
        }
    }
}
