public class Breathing : Activity {
    public void BreatheIn()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        for (int i = 5; i >= 0; i--)
        {
            string currentMessage = "Breath In..." + i;
            Console.Write(currentMessage);
            Thread.Sleep(1000);
            foreach (char c in currentMessage) {Console.Write("\b"); }
        }
    }
    public void BreatheOut()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

        for (int i = 5; i >= 0; i--)
        {
            string currentMessage = "Breath Out.." + i;
            Console.Write(currentMessage);
            Thread.Sleep(1000);
            foreach (char c in currentMessage)
                Console.Write("\b");   
        }
    }
    public void breathingLoop()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration/1000);
        //int i = 0;

        while (DateTime.Now < endTime)
        {
            BreatheIn();
            BreatheOut();
            //i ++;
        }
    }
}