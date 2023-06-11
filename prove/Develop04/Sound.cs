using System.Diagnostics;
public class Sound : Activity {
    private List<string> _responses = new List<string>();
    public Sound() {
        SetActivityDetails("Sound", "Listen to the world around you and list the things that you hear around you");
    }

    public override void Display()
    {
        base.Display();
        PerformExercise();
        DisplayCongratualations();
        DisplayResponses(_responses.Count);
    }

    public void PerformExercise() {
        Console.WriteLine("Listen to the world around you");
        Console.WriteLine("What do you hear?");
        Stopwatch soundTimer = new Stopwatch();
        soundTimer.Start();
        while(soundTimer.Elapsed.TotalSeconds < GetDuration()) {
            string userInput = Console.ReadLine();
            _responses.Add(userInput);
        }
        soundTimer.Stop();
        soundTimer.Reset();
        Console.WriteLine($"\nYou wrote {_responses.Count} different responses!");
    }
}