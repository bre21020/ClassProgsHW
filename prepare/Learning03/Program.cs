using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");

        //string response;
        
        //while (response == "yes") {
        //    Console.Write("Do you want to continue? ");
        //    response = Console.ReadLine();
        //}

        //do {
        //    Console.Write("Do you want to continue? ");
        //    response = Console.ReadLine();       
        //} while (response == "yes");

        //for (int i = 0; i < 10; i++) {
        //    Console.WriteLine(i);
        //}        

        //for (int i = 2; i <= 20; i = i + 2) {
        //    Console.WriteLine(i);
        //}

        //Console.WriteLine("bye");

        //foreach (string color in colors) {
        //    Console.WriteLine(color);
        //}

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,11);

        int guess = 0;
        int guesses = 0;

        while (guess != number) {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);
            guesses ++;
            if (guess > number) {
                Console.WriteLine("The number is less than " + guess);
            } else if (guess < number) {
                Console.WriteLine("The number is greater than " + guess);
            } else {
                //Console.WriteLine("error");
            }
        }
        if (guesses == 1) {
        Console.WriteLine("You got it in 1 guess!");
        } else { 
            Console.WriteLine("You got it in " + guesses + " guesses!");
        }
    }
}