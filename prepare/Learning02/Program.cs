using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Graphic Designer";
        job2._company = "Nintendo";
        job2._startYear = 2022;
        job2._endYear = 2024;

        job1.Display();
        job2.Display();

        Resume ta = new Resume();
        ta._name = "Treven Amidan";
        ta._jobs.Add(job1);
        ta._jobs.Add(job2);

        ta.Display();
    }
}