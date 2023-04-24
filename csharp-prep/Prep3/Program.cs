using System;

class Program
{
    static void Main(string[] args)
    {

        string playAgain = "yes";
        while (playAgain == "yes") {
            // Console.Write("What is the magic number? ");
            // string magicNumber = Console.ReadLine();
            // int number = int.Parse(magicNumber);

            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int userNumber = 0;
            int numberOfGuesses = 0;
            while (userNumber != number) {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();

                userNumber = int.Parse(userInput);
                if (userNumber == number) {
                    Console.WriteLine("You guessed it!");
                }
                else if (userNumber < number) {
                    Console.WriteLine("Higher");
                }
                else if (userNumber > number) {
                    Console.WriteLine("Lower");
                }
                Console.WriteLine();
                numberOfGuesses += 1;

            }

            Console.WriteLine($"Congratulations, the number was {number}!");
            Console.WriteLine($"You had {numberOfGuesses} guesses!");
            Console.WriteLine();

            Console.Write("Would you like to play again (Yes/No)? ");
            playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();
        }
    }
}