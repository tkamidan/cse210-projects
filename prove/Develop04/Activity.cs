using System.Diagnostics;
public class Activity {
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(){

    }

    public virtual void Display() {
        Console.Clear();
        Console.WriteLine($"The activity you are going to be doing is {_activityName}.\n{_description}");
        Console.Write("Enter the duration in seconds you want to do the activity: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Stopwatch startTimer = new Stopwatch();
        startTimer.Start();
        int second = 5;
        while(second > 0) {
            Console.WriteLine($"Activity beginning in {second}");
            Thread.Sleep(1000);
            Console.Clear();
            second -= 1;
        }
    }

    public void DisplayCongratualations(){
        Console.Clear();
        Stopwatch congratsTimer = new Stopwatch();
        congratsTimer.Start();
        while (congratsTimer.Elapsed.TotalSeconds < 5) {
            Console.WriteLine($"You did it!\nYou completed the {_activityName} activity in {_duration} seconds!");
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"You did it!\nYou completed the {_activityName} activity in {_duration} seconds!");
            Console.WriteLine("..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"You did it!\nYou completed the {_activityName} activity in {_duration} seconds!");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.Clear();
        }
        
        
    }

    public void DisplayResponses(int responses) {
        Console.Clear();
        Stopwatch responsesTimer = new Stopwatch();
        responsesTimer.Start();
        while (responsesTimer.Elapsed.TotalSeconds < 5) {
            Console.WriteLine($"You wrote {responses} different responses!");
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"You wrote {responses} different responses!");
            Console.WriteLine("..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"You wrote {responses} different responses!");
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.Clear();
        }

    }

    public int GetDuration() {
        return _duration;
    }

    public string GetRandomVariable(List<string> list) {
        var random = new Random();
        var randomNumber = random.Next(list.Count);
        return list[randomNumber];
    }

    public void SetActivityDetails(string activityName, string description) {
        _activityName = activityName;
        _description = description;
    }
}