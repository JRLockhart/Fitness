﻿using System;

namespace Fitness
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningTotal = 0.0;

            while (true)
            {
                // Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    
                    try
                    {
                        var minutes = double.Parse(entry);
                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not a valid number" +
                                "1");
                            continue;
                        }

                        if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing, am I right?");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go Hot Stuff!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja warrior in training!");
                        }
                        else
                        {
                            Console.WriteLine("Now you are showing off!");
                        }
                        // Add minutes exercised to total
                        runningTotal += minutes;
                  
                        // Display total minutes excercied to the screen
                        Console.WriteLine("You've exercised for " + entry + " minutes, and have worked out for " + runningTotal);
                        }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid entry");
                        continue;
                    }
                 
                }
                // Repeat until user in finished             
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
