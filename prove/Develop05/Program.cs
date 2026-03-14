using System;

partial class Program
{
    public static int userPoints = 0;
    public static List<Goal> goalsorsomething = new();

    static void Main(string[] args)
    {
        Console.Clear();

        void DisplayMenu() {
            Console.Write(userPoints + "\nMenu Options: \n     1. Create New Goal\n     2. List Goals\n     3. Save Goals\n     4. Load Goals\n     5. Record Events\n     6. Quit\nSelect a choice from the menu\n     ");
        }
        string getName() {
            Console.WriteLine("What is the name of your goal?\n     ");
            string goalName = Console.ReadLine();
            return goalName;
        }
        string getDesc() {
            Console.WriteLine("What is a short description of it??\n     ");
            string goalDesc = Console.ReadLine();
            return goalDesc;
        }
        int getPoints() {
            Console.WriteLine("What is the number of points associated with this goal??\n     ");
            int goalPoints = int.Parse(Console.ReadLine());
            return goalPoints;
        }
        int getBonusPoints() {
            Console.WriteLine("How many points do you get for fully completing this goal???\n     ");
            int goalPoints = int.Parse(Console.ReadLine());
            return goalPoints;
        }
        int getChecklistData() {
            Console.WriteLine("How many times does this goal need to be completed for a bonus?\n     ");
            int goalDesc = int.Parse(Console.ReadLine());
            return goalDesc;
        }
        void displayGoals() {
            int number = 0;
            foreach (Goal goal in goalsorsomething) {
                number++;
                Console.WriteLine(number + ". " + goal.showGoal(goal));
            }
        }

        int MenuOption = 0;
        while (MenuOption != 6) {
            DisplayMenu();
            string SelectedMenuOption = Console.ReadLine();
            MenuOption = int.Parse(SelectedMenuOption);

            if (MenuOption == 1) {
                Console.Clear();
                int goalTypeMenuOption = 0;
                if (goalTypeMenuOption != 1 || goalTypeMenuOption != 2 || goalTypeMenuOption != 3) {
                    Console.Write("The types of goals are:\n     1. Simple Goal\n     2. Eternal Goal\n     3. Checklist Goal\nWhich type of goal would you like to create?\n  ");
                    goalTypeMenuOption = int.Parse(Console.ReadLine());
                    Console.WriteLine(goalTypeMenuOption);
                    if (goalTypeMenuOption == 1) {
                        goalsorsomething.Add(new SimpleGoal(getName(), getDesc(), getPoints(), "simple"));
                    } else if (goalTypeMenuOption == 2) {
                        goalsorsomething.Add(new EternalGoal(getName(), getDesc(), getPoints(), "eternal"));
                    } else if (goalTypeMenuOption == 3) {
                        goalsorsomething.Add(new ChecklistGoal(getName(), getDesc(), getPoints(), "checklist", getChecklistData(), getBonusPoints()));
                    }
                }
                Console.Clear();
            } else if (MenuOption == 2) {
                Console.Clear();
                displayGoals();
                Console.Write("Press Enter to continue\n");
                Console.ReadLine();
                Console.Clear();
            } else if (MenuOption == 3) {
                SaveGoals();
                Console.ReadLine();
                Console.Clear();
            } else if (MenuOption == 4) {
                LoadGoals();
                Console.ReadLine();
                Console.Clear();
            } else if (MenuOption == 5) {
                Console.Clear();
                displayGoals();
                Console.WriteLine("Which goal would you like to complete?\n     ");
                int goalTypeMenuOption = int.Parse(Console.ReadLine());
                goalsorsomething[goalTypeMenuOption - 1].CompleteGoal(goalsorsomething[goalTypeMenuOption - 1]);
            } else if (MenuOption == 7) {
                Console.WriteLine("tfffLfttffffffLLffffttttttttttt1tfffffffffftttttt111111tffffffffftttff\nfttfffttfffffffffttfftttttt1t1tt11tfffffftttttt111t111111ttffffLLffttf\nLfttttffLLLfttttftfLftttttttffffttttffffttttfftt11t111tt111ttfffLffttf\nLLffttfLLffttfffftfLfttttttffttt11111ttttffffffftt1111tft11111ttfffftt\nLLLfftffttttffLffftfftttttft1i,,::::,iitffffffffftt111tft1tttt1ttffLft\nLLLfttttffftffffftfttttttff1:,,,,,,,,::itfffffffft11111111ttttttttttt1\nLLLfttfftffffffffLLLftttttt,::,:::,,,,::1tfffftfft11111ttt1ttt1tfttt11\nLffftfLfffttfLLffLLLfttttti,,,iii11111,:i11ttffft111111tfft11t11tt1ttt\nfttttfffffttLLLLfLLLftttfti:,,,iiiiiiii,it111tt111t1111tffttfftt11ttft\nttttttttttttfLLLffLLfttttt1,,,,,,iiiiii,1tft11tt1111111tfftffffttttttt\nffffffffttffttLLfffLfttttt11i,,,,iiiiiii1tt11tfftt11111ttt1fffttt1tttt\nffffffffttffftffttftttttff1ii,,,,iii1iii111tt1ttttt1111t111ffttffttfff\nfffffffttttttttttffftttttft1ii,,,ii1iii111tfft11ttt111111t1tt1tfft1ttf\nfffffftttttttt11fffftttt1t111iiii,iiiii11ttffft11111111ttttttt1tt11ttf\nfttttttttffttt11tffttttttt11ttii,,,iiii11i1ffftt1111111tttt111tttt11tt\ntttttttfffftttt11tfftttttt111t1i,,,iiii1i,,:,i1111t1111ttt111t1tfftt11\nfffftttffffttffttttft111tt11111i,,,iiii1,,,....,:::,i11tt111tt11tffftt\nffffttttfffttffttttft1111111111,,,,,,,it,,...........,:it111ttt1tffftt\nffft111tffttfttttttt1111t1i,:,11i1i,,1t1:,,............,itt11tt1tfftt1\nttt1ttt11ttttttftt111111i:,..:1111iii11,,...............,tt111t11ttttt\nttttffftt111ttffftt11i,,.,...,iiii,,,,:,,...............:1ttt1111ttfff\n11ttttttttttfffffft1:,..........::::::,,,...............,1ttttt11ttfff\n11ttttttttttfffffft1:...........:,::,:..................,1tttttt1ttfff\n1ttftttfftttttffft11:...........,:::::..................,1tttft11tffff\n1tttttttttttttttttt1,...........,::::,...................,t1t1111tffff\n1tttttttt1tfftttttt1:...........,::::,...... ............,1111tt11ffff\n1tttttttt1tffftttft1:...........,:::,,....................it1ttt11tfff\n1ttttttttttffttttttt:...........,::,,.....................:111tt11tttt\n1tftttttftttttttttt1,,:,:.......,:,,,....................,,1111t11tttt\n1ttffffffttttfffft11ii1i:.......,:,,,.....................,1tt1111tttt\n1tttttttttttttttttti,,,,:.......,:,,,....... .............,itt1111tttt\n1111111ttttttttttt1i,,,,:.......,:,,,......................itt11111111\n1111111ttttttttttt1,,,,,:...... ,:,,,,.....................itt11t11111\n1111111tttttttttt1,:,::,,...... ,:...,.....................ittttt11111\n111111111tttttttt1i,.....  .... .:........................,i1tttt11111\n1111111111t11t11111,,....,,.... ,:::,,,...................,11ttttt11t1\n\n");
            } else if (MenuOption == 6) {
            } else {
                Console.Write("PICK A VALID OPTION\n");
            }
        }
        Console.WriteLine("BYE");
    }
}
