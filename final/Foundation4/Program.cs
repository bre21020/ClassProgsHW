using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        Running running = new Running("02 Apr 2026", 30, 3);
        //Console.WriteLine(running.GetSummary());

        Cycling cycling = new Cycling("02 Apr 2026", 30, 3);
        //Console.WriteLine(cycling.GetSummary());

        Swimming swimming = new Swimming("02 Apr 2026", 30, 3);
        //Console.WriteLine(swimming.GetSummary());

        List<Activity> Activities = new List<Activity>();
        Activities.Add(running);
        Activities.Add(cycling);
        Activities.Add(swimming);

        foreach (Activity activity in Activities) {
            Console.WriteLine(activity.GetSummary());
        }

    }
}