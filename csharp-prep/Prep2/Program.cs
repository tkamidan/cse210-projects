using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();

        float percentage = float.Parse(userInput);
        string grade = " ";
        if (percentage >= 90) {
            grade = "A";
        }
        else if (percentage >= 80) {
            grade = "B";
        }
        else if (percentage >= 70) {
            grade = "C";
        }
        else if (percentage >= 60) {
            grade = "D";
        }
        else if (percentage < 60) {
            grade = "F";
        }
        else {
            grade = "N/A";
        }
        string pass_or_fail = " ";
        if (percentage >= 70) {
            pass_or_fail = "Congratulations, you passed!";
        }
        else if (percentage < 70) {
            pass_or_fail = "I'm sorry, but you failed";
        }
        else {
            pass_or_fail = "Invalid item entered";
        }
        float last_digit = percentage % 10;
        string plus_or_minus = "";
        if (last_digit >= 7 && !(grade == "A" || grade == "F")) {
            plus_or_minus = "+";
        }
        else if (last_digit < 3 && grade != "F") {
            plus_or_minus = "-";
        }
        Console.WriteLine($"Your letter grade is {grade}{plus_or_minus}!");
        Console.WriteLine(pass_or_fail);
    }
}