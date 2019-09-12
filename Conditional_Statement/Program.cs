/*
 Author: Amanda Blakley
 Date: 9/10/2019
 Comments: This C# console application code demonstrates the use of 
            conditional statements after getting input from users
*/

using System;

namespace Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input 

            Console.WriteLine("What grade do you expect to receive in ISM4300? Please enter digits only...");

            // Use a try catch block for user input exceptions

            try
            {
                // This variable will gather user input

                string input = Console.ReadLine();

                // This variable will be used to store the grade after input variable is parsed to decimal

                decimal grades = decimal.Parse(input);

                // if/else if/else block is used to test the user's input 

                if (grades >= 98 && grades <=100)
                {
                    Console.WriteLine("Your grade is an A+");
                }
                else if (grades >= 92 && grades <= 97)
                {
                    Console.WriteLine("Your grade is an A");
                }
                else if (grades >= 90 && grades <= 91)
                {
                    Console.WriteLine("Your grade is an A-");
                }
                else if (grades >= 88 && grades <= 89)
                {
                    Console.WriteLine("Your grade is a B+");
                }
                else if (grades >= 82 && grades <= 87)
                {
                    Console.WriteLine("Your grade is a B-");
                }
                else if (grades >= 78 && grades <= 79)
                {
                    Console.WriteLine("Your grade is a C+");
                }
                else if (grades >= 72 && grades <= 77)
                {
                    Console.WriteLine("Your grade is a C");
                }
                else if (grades >= 70 && grades <= 71)
                {
                    Console.WriteLine("Your grade is a C-");
                }
                else if (grades >= 68 && grades <= 69)
                {
                    Console.WriteLine("Your grade is a D+");
                }
                else if (grades >= 62 && grades <= 67)
                {
                    Console.WriteLine("Your grade is a D");
                }
                else if (grades >= 60 && grades <= 61)
                {
                    Console.WriteLine("Your grade is a D-");
                }
                else if (grades <= 60)
                {
                    Console.WriteLine("I'm sorry, you have failed the course");
                }
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
