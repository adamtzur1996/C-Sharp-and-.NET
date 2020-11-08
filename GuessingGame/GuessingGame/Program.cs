using System;
using System.Threading;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run the function below
            GetAppInfo();

            GreetUser();

            while(true) {
                //int correctNumber = 7;
                Random randomNo = new Random();
                int correctNumber = randomNo.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 - 10.");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong, try again!");
                    }
                }
                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

                Console.WriteLine("Do you want to play again [Y or N]?");

                string answer = Console.ReadLine().ToUpper();

               if(answer == "Y")
                {
                    continue;
                } else if(answer == "N"){
                    return;
                } 
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Set app vars
            string AppName = "Number Guesser";
            string AppVersion = "1.0.0";
            string Author = "Adam Tzur";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", AppName, AppVersion, Author);

            //Reset color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", name);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }

    }
}
