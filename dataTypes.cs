using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)


        {
            //Data Types

            string Name = "Matt";
            char Grade = 'A'; // Character should be SINGLE QUOTES
            int Score = 99;
            double Money = 2.99;
            bool isMale = true;

            // String Tricks

            Console.WriteLine("Hello\nMatt"); // New Line
            string Phrase = "Matt " + "Is Cool"; // Concat
            Console.WriteLine(Phrase.Length); // Length
            Console.WriteLine(Phrase.ToUpper()); // UpperCase String
            Console.WriteLine(Phrase.ToLower()); // LowerCase String
            Console.WriteLine(Phrase.Contains("Matt")); // Search a String
            Console.WriteLine(Phrase[0]); //Index Searching
            Console.WriteLine(Phrase.IndexOf("Cool")); // Index of first occurance of argument
            Console.WriteLine(Phrase.Substring(0, 4)); // Search specific index/length in string

            // Getting User Input

            Console.Write("Enter your name: ");
            string myName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string myAge = Console.ReadLine();
            Console.WriteLine("My name is " + myName + ". I am " + myAge + " years old.");

            // Numbers

            int newNum = Convert.ToInt32("666"); // Convert string to number
            Console.WriteLine(newNum + 1);

            Console.Write("Enter a Number: ");
            int NUMBER = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NUMBER + NUMBER);





            // This will help keep console open when you run your program
            Console.ReadLine();
        }
    }
}
