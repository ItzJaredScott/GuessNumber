using System;

class NumberGuessingGame
{
    static void Main()
    {
        Random rand = new Random();
        bool playAgain;

        do
        {
            Console.WriteLine("Choose difficulty: ");
            Console.WriteLine("1 = Easy (1-10)");
            Console.WriteLine("2 = Medium (1-50)");
            Console.WriteLine("3 = Hard (1-100)");

            int max = 10; // default
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Enter 1, 2, or 3:");
            }

            switch (choice)
            {
                case 1:
                    max = 10;
                    break;
                case 2:
                    max = 50;
                    break;
                case 3:
                    max = 100;
                    break;
                default:
                    Console.WriteLine("Invalid choice, defaulting to Easy.");
                    max = 10;
                    break;
            }

            int numberToGuess = rand.Next(1, max + 1);
            int guess;
            int guessCount = 0;

            do
            {
                Console.Write($"Enter your guess (1-{max}): ");
                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.Write("Invalid input. Please enter a number: ");
                }

                guessCount++;

                if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low, try again.");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("Too high, try again.");
                }
                else
                {
                    Console.WriteLine($"Correct! You guessed it in {guessCount} tries.");
                }
            }
            while (guess != numberToGuess);

            Console.Write("Would you like to play again? (Y/N): ");
            string playAgainInput = Console.ReadLine().ToUpper();
            playAgain = (playAgainInput == "Y");

        } while (playAgain);

        Console.WriteLine("Thanks for playing!");
    }
}