namespace Number_Enigma_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            PlayGame();
        }

        static void GetAppInfo()
        {
            string appName = "Number Enigma Game";
            string appVersion = "1.0.0";
            string appAuthor = "Jai Vang";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2} \n", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hello {0}, let's play a game... \n", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void PlayGame()
        {
            while (true)
            {
                Random random = new Random();

                // Generate a number from 1 to 10
                int correctNumber = random.Next(1, 10);
                int guessNumber = 0;
                Console.WriteLine("Guess a number between 1 and 10 \n");

                while (guessNumber != correctNumber)
                {
                    string input = Console.ReadLine();


                    /*
                    * This line checks if the input can be successfully converted to an integer. 
                    * If not, it likely means that the input is not a valid numeric value, 
                    * and the condition in the if statement will be true, 
                    * allowing you to handle the case where the user entered an invalid input.
                    */
                    if (!int.TryParse(input, out guessNumber))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please user an actual number. \n");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess variable
                    guessNumber = Int32.Parse(input);

                    // Match guess to correct number
                    if (guessNumber != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Please try again. \n");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!! \n");


                // Ask to play again
                var KeepLooping = true;
                while (KeepLooping)
                {
                    Console.WriteLine("Play Again? [Y or N] \n");
                    Console.WriteLine();
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        KeepLooping = false;
                        continue;
                    }
                    else if (answer == "N")
                    {
                        Console.WriteLine("Thanks for playing! ByeByeBye! \n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Enter 'Y' or 'N' only \n");
                        continue;
                    }
                }
            }
        }
    }
}
