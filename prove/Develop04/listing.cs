public class Listing : Activity {
    public List<string> _prompts = new List<string> {
        " --- When have you felt the Holy Ghost this month? ---",
        " --- What scriptures have you read this week? ---",
        " --- Why did the chicken cross the road? ---",
        " --- If your social security number was the number of children you had, how many children would you have? ---"
    };
    public void displayPrompt() {
        Random random = new Random();
        //int i = new Random(0, _prompts);
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
    }

    public void listingLoop() {
        Console.Clear();
        displayPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration/1000);
        int i = 0;
        while (DateTime.Now < endTime){
            Console.Write("> ");
            Console.ReadLine();
            i ++;
        }
        Console.WriteLine("You listed " + i + " items!");
    }
}