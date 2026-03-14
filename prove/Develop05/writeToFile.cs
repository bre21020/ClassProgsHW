using System.IO;
// I didn't write literally any of this, I've been working on this for 6 hours and we were never taught how to do the writing and reading. The little things they have in the assignment that tell you how to do it didn't help. So the entirety of this specific file was written by claude ai but considering how long it takes to get these graded you probably won't see this message for another month, and by that time it wont really matter
partial class Program {
    static void SaveGoals() {
        string filename = "goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(userPoints);
            foreach (Goal goal in goalsorsomething)
            {
                if (goal._type == "checklist")
                {
                    outputFile.WriteLine($"{goal._type},{goal._name},{goal._desc},{goal._points},{goal._completed},{goal._checklist},{goal._bonus},{goal._completedChecklist}");
                }
                else
                {
                    outputFile.WriteLine($"{goal._type},{goal._name},{goal._desc},{goal._points},{goal._completed}");
                }
            }
        }
        Console.WriteLine("Goals saved! Press Enter to continue.");
    }

    static void LoadGoals() {
        string filename = "goals.txt";

        if (!File.Exists(filename)) {
            Console.WriteLine("No save file found. Press Enter to continue.");
            return;
        }

        goalsorsomething.Clear();
        string[] lines = File.ReadAllLines(filename);

        userPoints = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string type = parts[0];

            if (type == "simple")
            {
                SimpleGoal g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), "simple");
                g._completed = bool.Parse(parts[4]);
                goalsorsomething.Add(g);
            }
            else if (type == "eternal")
            {
                EternalGoal g = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), "eternal");
                g._completed = bool.Parse(parts[4]);
                goalsorsomething.Add(g);
            }
            else if (type == "checklist")
            {
                ChecklistGoal g = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), "checklist", int.Parse(parts[5]), int.Parse(parts[6]));
                g._completed = bool.Parse(parts[4]);
                g._completedChecklist = int.Parse(parts[7]);
                goalsorsomething.Add(g);
            }
        }
        Console.WriteLine("Goals loaded! Press Enter to continue.");
    }
}
