public class Menu {
    Breathing breathingActivity = new Breathing();
    Reflection reflectionActivity = new Reflection();
    Sound soundActivity = new Sound();
    Listing listingActivity = new Listing();

    public void DisplayMainMenu() {
        int choice = 0;
        while(choice != 6) {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Sound Activity");
            Console.WriteLine("4. Listing Activity");
            Console.WriteLine("5. Random Activity");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Enter your decision: ");
            choice = int.Parse(Console.ReadLine());

            switch(choice) {
                case 1:
                    breathingActivity.Display();
                    break;
                case 2: 
                    reflectionActivity.Display();
                    break;
                case 3:
                    soundActivity.Display();
                    break;
                case 4:
                    listingActivity.Display();
                    break;
                case 5:
                    PickARandomActivity();
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("Have a great day!");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Not a valid option");
                    break;
            }
        }
    }

    public void PickARandomActivity() {
        var random = new Random();
        int ranNum = random.Next(1,5);
        switch(ranNum) {
            case 1:
                breathingActivity.Display();
                break;
            case 2:
                reflectionActivity.Display();
                break;
            case 3:
                soundActivity.Display();
                break;
            case 4:
                listingActivity.Display();
                break;
        }
    }
}