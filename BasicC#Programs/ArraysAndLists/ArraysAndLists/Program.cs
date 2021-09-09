using System;
using System.Collections.Generic;


class Program
{
    static void Main()
        // Creating a string array
    {
        string[] stringArray = { "This is index 0", "This is index 1", "This is index 2", "This is index 3" };
        Console.WriteLine("Please select an Index of a string Array:");
        // Storing user input in variable called stringSelect
        int stringSelect = Convert.ToInt32(Console.ReadLine());
        // Using a while loop to keep prompting user until valid index is given
        while (stringSelect < 0 || stringSelect > 3)
        {
            Console.WriteLine("Index " + stringSelect + " does not exist, please try again:");
            stringSelect = Convert.ToInt32(Console.ReadLine());
        }
        // Writing the value of the index the user gave
        Console.WriteLine(stringArray[stringSelect]);


        // Creating a string array
        int[] intArray = { 45, -82, 7, 5250, 32, 21000 };
        Console.WriteLine("Please select an Index of an integer Array:");
        // Storing user input in variable called intSelect
        int intSelect = Convert.ToInt32(Console.ReadLine());
        // Using a while loop to keep prompting user until valid index is given
        while (intSelect < 0 || intSelect > 5)
        {
            Console.WriteLine("Index " + intSelect + " does not exist, please try again:");
            intSelect = Convert.ToInt32(Console.ReadLine());
        }
        // Writing the value of the index the user gave
        Console.WriteLine(intArray[intSelect]);


        // Creating a list of strings
        List<string> intList = new List<string>();
        intList.Add("String zero");
        intList.Add("String one");
        intList.Add("String two");
        intList.Add("String three");
        intList.Add("String four");
        Console.WriteLine("Please select an Index of a list:");
        // Storing user input in variable called listSelect
        int listSelect = Convert.ToInt32(Console.ReadLine());
        // Using a while loop to keep prompting user until valid index is given
        while (listSelect < 0 || listSelect > 4)
        {
            Console.WriteLine("Index " + listSelect + " does not exist, please try again:");
            listSelect = Convert.ToInt32(Console.ReadLine());
        }
        // Writing the value of the index the user gave
        Console.WriteLine(intList[listSelect]);
        Console.Read();
    }
}
