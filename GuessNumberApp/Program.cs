using System;

namespace GuessNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            String wantToPlayAgain;
            Console.WriteLine("Guess the Number!");
            Console.WriteLine("\nI'm thinking of a number from 1 to 10\n");
            Random rand = new Random();
            do
            {
                randomNumber = rand.Next(1, 11);
                playGame(randomNumber);
                Console.WriteLine("\nWould you like to play again? (y/n): ");
                wantToPlayAgain = Console.ReadLine();
            } while (wantToPlayAgain.Equals("y"));
        }

        private static void playGame(int randomNumber)
        {
            int number,noOfTries=0;
            do
            {
                String input;
                Console.WriteLine("Your guess: ");
                input = Console.ReadLine();
                number = Convert.ToInt32(input);
                if (number > randomNumber)
                {
                    Console.WriteLine("Too High");
                }
                if (number < randomNumber)
                {
                    Console.WriteLine("Too Low");
                }
                noOfTries++;
            } while (number != randomNumber);
            Console.WriteLine("You guessed it in " + noOfTries + " tries.");
        }
    }
}
