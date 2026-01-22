using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Cook";
        job1._company = "Food Place";
        job1._startYear = 1;
        job1._endYear = 1997;
        //job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Eater";
        job2._company = "Food Place Customer Division";
        job2._startYear = 2;
        job2._endYear = 1996;

        Resume res1 = new Resume();
        res1._name = "Dave";
        res1._jobs.Add(job1);
        res1._jobs.Add(job2);
        res1.Display();

    }
}