public class Prompt {
    public List<string> _prompts;

    public Prompt(){
        _prompts.Add("How was your day?");
        _prompts.Add("Describe what you did today");
        _prompts.Add("What did you eat today?");
        _prompts.Add("Where is a place that you felt most happy today and why?");
        _prompts.Add("Write a letter to someone that you always want to thank but have never had the chance to do so.");
    }

    public string GetRandomPrompt() {
        var random = new Random();
        var randomNumber = random.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
}