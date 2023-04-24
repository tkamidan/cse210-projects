using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        float number = 1;
        while (number != 0) {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = float.Parse(userInput);
            if (number != 0) {
                numbers.Add(number);
            }
        }

        float sum = 0;
        float numOfNums = 0;
        float largestNumber = numbers[0];
        foreach (float num in numbers) {
            sum += num;
            numOfNums += 1;
            if (num > largestNumber) {
                largestNumber = num;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        float average = sum / numOfNums;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}