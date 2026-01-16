using System;

class Program
{
    static void Main(string[] args)
    {
        //DisplayMessage();
        //DisplayMessageCustom("HEEBEEGEEBEE");
        //Console.WriteLine(AddNumbers(5, 7));
        //DisplayMessageCustom(AddNumbers(643, 7).ToString());
        //Looked up ToString on the internet, seems pretty useful
        //int x;
        //TestPassByReferenceUsingOut(out x);
        //Console.WriteLine(x);

        //DisplayMessageCustom("Welcome to the program");
        //DisplayMessageCustom("Your name is " + PromptUserName());
        //DisplayMessageCustom("Your favorite number is " + PromptUserNumber());
        //int BirthYear;
        //PromptUserBirthYear (out BirthYear);
        //DisplayMessageCustom("Your birth year is " + BirthYear);
        //SquareNumber (BirthYear);
        string UserName;
        int UserNumber;
        int BirthYear;
        DisplayMessageCustom("Welcome to the program");
        PromptUserName(out UserName);
        PromptUserNumber(out UserNumber);
        PromptUserBirthYear(out BirthYear);
        //Console.WriteLine(UserName + UserNumber + BirthYear);
        DisplayResult(UserName, UserNumber, BirthYear);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Yo");
    }
    static void DisplayAnotherMessage()
    {
        Console.WriteLine("YOYO");
    }
    static void DisplayMessageCustom(string Message)
    {
        Console.WriteLine(Message);
    }
    static int AddNumbers(int first, int second)
    {
        int sum = first + second;
        return sum;
    }

    static void TestPassByReferenceUsingOut(out int x) {
        x = 199;
    }

    //public static void Main(string[] args) {
    //    int x;
    //    TestPassByReferenceUsingOut(out x);
    //   Console.WriteLine(x);
    //}

    static void PromptUserName(out string UserName) {
        Console.Write("What is your username? ");
        UserName = Console.ReadLine();
        //return Console.ReadLine();
    }

    static void PromptUserNumber(out int UserNumber) {
        Console.Write("What is your favorite number? (ex: 5) ");
        UserNumber = int.Parse(Console.ReadLine());
        //return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear (out int BirthYear) {
        Console.Write("What is your birth year? (ex: 2005) ");
        BirthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber (int number) {
        return number * number;
    }

    static void DisplayResult (string name, int number, int year) {
        Console.WriteLine(name + ", your number squared is " + number);
        Console.WriteLine(name + ", your will turn " + (2026 - year) + " this year.");

    }
}