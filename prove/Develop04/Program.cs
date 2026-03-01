using System;

class App
{
    static void Main(string[] args)
    {

        void DisplayMenu() {
            string Menu = "Menu Options:\n   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. Quit";
            Console.WriteLine(Menu);
        }
        Console.Clear();
        
        

        string menuState = "unspecified";
        while (menuState != "quit") {
            //Console.Clear();
            DisplayMenu();
            Console.Write("Please Make A Selection:\n ");
            menuState = Console.ReadLine();
            int menuNumber = int.Parse(menuState);
            if (menuNumber == 1) {
                Console.Clear();
                Breathing breathingActivity = new Breathing();
                breathingActivity._description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                breathingActivity._name = "Breathing Activity";
                breathingActivity.loading();
                breathingActivity.startMessage();
                breathingActivity.getDuration();
                breathingActivity.breathingLoop();
                breathingActivity.endMessage();
                breathingActivity.loading();
                Console.Clear();
                //Console.Write("BREATHING\n");
            } else if (menuNumber == 2) {
                Console.Clear();
                Reflecting reflectingActivity = new Reflecting();
                reflectingActivity._description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                reflectingActivity._name = "Reflecting Activity";
                reflectingActivity.loading();
                reflectingActivity.startMessage();
                reflectingActivity.getDuration();
                reflectingActivity.reflectingLoop();
                reflectingActivity.endMessage();
                reflectingActivity.loading();
                Console.Clear();
                Console.Write("REFLECTING\n");
            } else if (menuNumber == 3) {
                Console.Clear();
                Listing listingActivity = new Listing();
                listingActivity._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                listingActivity._name = "Listing Activity";
                listingActivity.loading();
                listingActivity.startMessage();
                listingActivity.getDuration();
                listingActivity.listingLoop();
                listingActivity.endMessage();
                listingActivity.loading();
                Console.Clear();
                Console.Write("LISTING\n");
            } else if (menuNumber == 4) {
                Console.Clear();
                Console.Write("Quitting\n");
                menuState = "quit";
            } else if (menuNumber == 5) {
                Console.Clear();
                Activity rick = new Activity();
                rick.rickLoading();
            } else {
                Console.Clear();
                Console.WriteLine("Invalid Choice\n");
            }
        }

        Console.WriteLine("BYE");
        
    }


    
}

//cd 'C:\Users\bakoj23ftw\Desktop\Class Progs\ClassProgsHW\prove\Develop04'
//cd Desktop/Homework\ Folder\ 3/Class\ Progs/ClassProgsHW/prove/Develop04
