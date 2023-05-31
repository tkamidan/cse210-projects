using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Treven Amidan", "Computer Science", "2.1", "1-21 odd");
        string studentInfo = mathAssignment.GetSummary();
        string mathInfo = mathAssignment.GetHomeworkList();
        Console.WriteLine(studentInfo);
        Console.WriteLine(mathInfo);
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Treven Amidan", "Computer Science", "Why Writing is Dumb?");
        studentInfo = writingAssignment.GetSummary();
        string writingInfo = writingAssignment.GetWritingInformation();
        Console.WriteLine(studentInfo);
        Console.WriteLine(writingInfo);
    }
}