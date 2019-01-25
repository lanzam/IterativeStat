/* Author: Mariel Lanza
   Date: 1/20/2018
   Comments: This C# console application demonstrates what I have learned about the iterative
   statements. On this project I will demonstrate the DO WHILE LOOP and using --/++ operators.
*/

using System;

namespace IterativeStat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a value to execute an iterative statement
            Console.WriteLine("Enter an integer value between 1 and 100");

            /* The TRY + CATCH block will verify user input
               CATCH will handle bad input and will display an error message
            */
            try
            {
                string input = Console.ReadLine(); // This variable wil hold the user's input 
                int input_used = int.Parse(input); // This variable will Parsed the user input to an integer
                
                // Test if the user input is a value between 0 and 50
                if ((input_used > 0) && (input_used <= 50))
                {
                    Console.WriteLine("DO + WHILE LOOP!");
                    Console.WriteLine("You have entered:" + input_used.ToString()); // 
                    do
                    {
                        Console.WriteLine("This is the current integer value in the loop:" + input_used.ToString());
                        input_used--; //  "--" decrement operator will decrement the value by 1 
                    }
                    while (input_used > 0);
                    Console.WriteLine("To EXIT the program press any key...");
                    Console.ReadKey(true);
                }
                // Test if the user input is a value between 50 and 100
                else if ((input_used >= 50) && (input_used <=100 ))
                {
                    Console.WriteLine("You have entered:" + input_used.ToString());
                    do
                    {
                        Console.WriteLine("This is the current integer value in the loop:" + input_used.ToString());
                        input_used++; //  "++" increment operator --> will increment the value by 1 
                    }
                    while (input_used < 101);
                    Console.WriteLine("To EXIT the program press any key...");
                    Console.ReadKey(true);
                }
                else
                {
                    // Display a message if the user input is greater than 100
                    Console.WriteLine("Please enter an integer value between 1 and 100");
                    Console.ReadKey(true);
                }

            } // End of try 
            catch
            {
                Console.WriteLine("Enter a valid integer value from 0 - 100 and try again");
                Console.WriteLine("To EXIT the program press any key...");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
        } // End of class
    } // End of namespace

