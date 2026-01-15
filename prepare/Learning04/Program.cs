using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        //List<int> numbers;
        //List<string> words;
        //numbers = new List<int>();

        //List<int> numbers2 = new List<int>();
        //List<string> words2 = new List<string>();

        //using System.Collections.Generic;

        ////////////////////////////

        //List<string> words = new List<string>();

        //words.Add("phone");
        //words.Add("keyboard");
        //words.Add("mouse");
        //words.Add("desk");

        //Console.WriteLine(words.Count);

        //foreach (string word in words) {
        //    Console.WriteLine(word);
        //}

        //for (int i = 0; i < words.Count; i ++) {
        //    Console.WriteLine(words[i]);
        //}

        List<int> numbers = new List<int>();
        int number = 999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        

        while (number != 0) {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0) {
                break;
            } else {
                numbers.Add(number);
                sum += number;
            }

            
        }

        int max = numbers[0];

        foreach (int number2 in numbers) {
            Console.WriteLine(number2);
            if (number2 > max) {
                max = number2;
            }
        }
        float average = sum / numbers.Count();
        Console.WriteLine("Sum of all numbers in the list is " + sum);
        Console.WriteLine("Max number in the list is " + max);
        Console.WriteLine("The average for this list is " + average);
    }
}