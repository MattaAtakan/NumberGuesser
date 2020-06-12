using System;


// Namespace
namespace NumberGuesser
{

    //Main class
    class Program
    {

        //Entry point method
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                // init correct number
                //int correctNumber = 7;

                //create new rand obj
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                // ask user for nb
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //make sure its a nb
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an accual number !");

                        // keep going
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct nb
                    if (guess != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Wrong number, plese try again !");
                    }
                }

                //Output sucess msg
                PrintColorMessage(ConsoleColor.Yellow, "Correct !! ");

                // ask to play agian
                Console.WriteLine("Play again? [Y or N]");

                //get anwer
                string answer = Console.ReadLine().ToUpper();

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

        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mateja Stojanovic";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;


            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // ask usrs name
            Console.WriteLine("Whats your name ?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;


            // Write out app info
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}