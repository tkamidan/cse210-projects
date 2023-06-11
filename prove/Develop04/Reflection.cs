using System.Diagnostics;
public class Reflection : Activity {

    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    public Reflection(){
        SetActivityDetails("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public override void Display()
    {
        base.Display();
        PerformExercise();
        DisplayCongratualations();
    }

    public void PerformExercise() {
        string ranPrompt = GetRandomVariable(_prompts);
        Console.WriteLine($"The random prompt is:\n{ranPrompt}");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        int second = 5;
        Console.Clear();
        while(second > 0) {
            Console.WriteLine($"Activity starting in {second}");
            Thread.Sleep(1000);
            Console.Clear();
            second -= 1;
        }
        Stopwatch durationTimer = new Stopwatch();
        durationTimer.Start();
        while(durationTimer.Elapsed.TotalSeconds < GetDuration()) {
            string ranQuestion = GetRandomVariable(_questions);
            Stopwatch reflectionTimer = new Stopwatch();
            reflectionTimer.Start();
            while(reflectionTimer.Elapsed.TotalSeconds < 10) {
                Console.Clear();
                Console.WriteLine(ranQuestion);
                Console.WriteLine(".");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(ranQuestion);
                Console.WriteLine("..");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(ranQuestion);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.Clear();
            }
            reflectionTimer.Stop();
            reflectionTimer.Reset();
        }
        durationTimer.Stop();
        durationTimer.Reset();
    }
}