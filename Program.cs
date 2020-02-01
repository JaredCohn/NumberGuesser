using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Runs GetAppInfo function to return Application details

            GreetUser(); // Runs GreetUser function to prompt users name and greet them.

            while (true)
            {

                // Create a new random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for input
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Prints error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number.");

                        //  Continue till proper input is received.
                        continue;
                    }

                    // Cast user's guess to int and puts in guess variable.
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Incorrect, guess again.");
                    }
                }
                // Output Success Message
                PrintColorMessage(ConsoleColor.Green, "You are correct!!");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get user's answer
                string answer = Console.ReadLine().ToUpper();

                // Rerun app if user answers yes. Close on No.
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // Sets and displays the Apps info.
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jared Cohn";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string input = Console.ReadLine();

            // Greet user
            Console.WriteLine("Hello {0}, let's play a game...", input);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Write warning
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
