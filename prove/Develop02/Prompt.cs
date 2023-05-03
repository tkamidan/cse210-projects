public class Prompt {

    List<string> _usedPrompts;
    List<string> _prompts;

    public Prompt()
    {
        _prompts.Add("How was your day?");
    }

    public string GetRandomPrompt() {
        return "This is a prompt";
    }

}