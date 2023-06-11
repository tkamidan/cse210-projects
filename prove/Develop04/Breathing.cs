using System.Diagnostics;
public class Breathing : Activity {

    public Breathing(){
        SetActivityDetails("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public override void Display()
    {
        base.Display();
        PerformExercise();
        DisplayCongratualations();
    }

    public void PerformExercise() {
        Stopwatch durationTimer = new Stopwatch();
        durationTimer.Start();
        Stopwatch breathTimer = new Stopwatch();

        while (durationTimer.Elapsed.TotalSeconds < GetDuration())
        {
            breathTimer.Start();
            
            Countdown("Breathe In", 5);
            
            Console.Clear();

            breathTimer.Restart();

            Countdown("Breathe Out", 5);

            Console.Clear();
        }
        breathTimer.Stop();
        breathTimer.Reset();


        durationTimer.Stop();
        durationTimer.Reset();
    }

    static void Countdown(string text, int duration)
        {
            for (int remainingSeconds = duration; remainingSeconds > 0; remainingSeconds--)
            {
                Console.Write(text);
                Console.Write(" ");
                Console.WriteLine(remainingSeconds);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
}