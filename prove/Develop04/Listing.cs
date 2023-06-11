using System.Diagnostics;
public class Listing : Activity {
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> _responses = new List<string>();
    public Listing(){
        SetActivityDetails("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public override void Display()
    {
        base.Display();
        PerformExercise();
        DisplayCongratualations();
        DisplayResponses(_responses.Count);
    }

    public void PerformExercise() {
        string ranPrompt = GetRandomVariable(_prompts);
        int second = 5;
        Console.Clear();
        while(second > 0) {
            Console.WriteLine($"The random prompt is: {ranPrompt}");
            Console.WriteLine($"Activity starting in {second}");
            Thread.Sleep(1000);
            Console.Clear();
            second -= 1;
        }
        Console.WriteLine($"The random prompt is: {ranPrompt}");
        Stopwatch listingTimer = new Stopwatch();
        listingTimer.Start();
        while(listingTimer.Elapsed.TotalSeconds < GetDuration()) {
            string userInput = Console.ReadLine();
            _responses.Add(userInput);
        }
        listingTimer.Stop();
        listingTimer.Reset();
    }
}