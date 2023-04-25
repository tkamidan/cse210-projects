using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName() {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }

        static int SquareNumber(int num) {
            int square = num * num;
            return square;
        }

        static void DisplayResult(string userName, int squareNumber) {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}.");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredUserNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredUserNumber);

    }
}