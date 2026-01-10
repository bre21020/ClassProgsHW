using System;

class Program
{
    static void Main(string[] args)
    {
        // Put code here
        Console.Write("What is your grade percentage? (ex: 85) ");
        int grade = int.Parse(Console.ReadLine());
        //Console.WriteLine(grade);
        string letter = "default";
        string message = " you pass!";

        if (grade >= 90)
        {
            letter = "A";
        } else if (grade >= 80)
        {
            letter = "B";
        } else if (grade >= 70)
        {
            letter = "C";
        } else if (grade >= 60)
        {
            letter = "D";
        } else
        {
            letter = "F";
            message = " YOU FAIL!";
        }
        Console.WriteLine(letter + message);
    }
}