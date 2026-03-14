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
            } else if (MenuOption == 6) {
            } else {
                Console.Write("PICK A VALID OPTION\n");
            }
        }
        Console.WriteLine("BYE");
    }
}
