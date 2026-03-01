public class Reflecting : Activity {
    public List<string> _prompts = new List<string> {
        " --- Think of a time when you did something really difficult. ---",
        " --- How do you if when you have a with a when you have a could do anything you wanted? ---"
    };
    public List<string> _questions = new List<string> {
        "> How did you feel when it was complete?",
        "> What is your favorite thing about this experience?",
        "> What was your least favorite thing about this experience?",
        "> Why?"
    };

    public void displayPrompt() {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
    }

    public void displayQuestion(int currentQuestion) {
        //int i = 0;
            for (int j = 5; j >= 0; j--)
            {
                string currentMessage = _questions[currentQuestion] + " " + j + "                                                            ";
                
                Console.Write(currentMessage);
                Thread.Sleep(1000);
                foreach (char c in currentMessage) {
                    Console.Write("\b");  
                }
            }
            //string currentLine = Console.ReadLine();
            //foreach (char c in currentLine) {
            //    Console.Write("\b");  
            //}
    }

    public void reflectingLoop() {
        displayPrompt();
        loading();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration/1000);
        int currentQuestion = 0;
        while (DateTime.Now < endTime) {
            displayQuestion(currentQuestion);
            currentQuestion += 1;
            if (currentQuestion > _questions.Count - 1) {
                currentQuestion = 0;
            }
        }
    }
}