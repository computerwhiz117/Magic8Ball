﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    //abstract class Carlos
    //{
    //   private static string name = "Carlos";
    //   public static string alias = "ComputerWhiz";
    //   private static int age = 18;
    //}

    /// <summary>
    /// Entry point for Magic 8 Ball program (By: ComputerWhiz) 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;
            
            TellPeopleWhatProgramThisIs();


            //Create a randomizer object
            Random randomObject = new Random();

            //Loop forever AND EVER HAHAHAHAHAAHAHAAHAHAHA!!!!!!!!!!!!!!!!!!!
            while(true)
            {
                string questionString = GetQuestionFromUser();

                int numberOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Processing answer, please stand by...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);

                if( questionString.Length == 0)
                {
                    Console.WriteLine("you need to type a question or who knows what's going to happen");
                    continue;
                }

                //Ensure that the user typed "quit" as the question
                if( questionString.ToLower() == "quit")
                {
                    break;
                }

                //if the user insults with 'you suck' smack them and close
                if( questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("You suck even more! Bye!");
                    break;
                }

                //if the user insults technology kick them out
                if( questionString.ToLower() == "technology sucks")
                {
                    Console.WriteLine("Well you suck a LOT more than your wheel, bye!!!!!!!!!!!!!!!!!!!");
                    break;
                }

                //If the user insults with 'you are horrible' kick them out
                if( questionString.ToLower() == "you are horrible")
                {
                    Console.WriteLine("Well you are more horrible, goodbye!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    break;
                }

                //If the user insults with 'you are terrible' kick them out
                if( questionString.ToLower() == "you are terrible")
                {
                    Console.WriteLine("Well you are more terrible, goodbye!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    break;
                }
                //Get a random #
                int randomNumber = randomObject.Next(4);

                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);

                //Use random number to determine response
                switch(randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("HELL NO!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("OMG YES");
                            break;
                        }
                }

            
            } //End of the while loop

            //Cleaning up
            Console.ForegroundColor = oldColor;
        }

        /// <summary>
        /// This will print the name of the program and who created it
        /// to the console
        /// </summary>
        static void TellPeopleWhatProgramThisIs()
        {
            //Change console text color
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("agic 8 Ball (by: ComputerWhiz)");
        }

        /// <summary>
        /// This function will return the text the user types
        /// </summary>
        /// <returns></returns>
        static string GetQuestionFromUser()
        {
            // This block of code will ask the user for a question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question?:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();

            return questionString;
        }
    }
}
