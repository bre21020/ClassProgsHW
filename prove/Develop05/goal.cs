using System;

class Goal {
    public string _name;
    public string _desc;
    public int _points;
    public bool _completed;
    public string _type;
    public int _checklist;
    public int _completedChecklist;
    public int _bonus;
    protected string getComplete(bool _completed) {
        string completion = "[ ]";
        if (_completed) {
            completion = "[X]";
        }
        return completion;
    }
    protected string getCompletionProgress(Goal goal) {
        return $"{goal._completedChecklist}/{goal._checklist}";
    }
    public virtual string showGoal(Goal goal) {
        return getComplete(_completed) + " " + _name + ": " + _desc;
    }
    public void CompleteGoal(Goal goal) {
        if (goal._completed != true) {
            if (goal._type == "simple") {
                _completed = true;
                Program.userPoints += goal._points;
            } else if (goal._type == "eternal") {
                Program.userPoints += goal._points;
            } else if (goal._type == "checklist") {
                if (_completedChecklist == _checklist -1 && _completed == false) {
                    Console.Write("Congradulations");
                    Console.ReadLine();
                    Program.userPoints += goal._points + goal._bonus;
                    _completed = true;
                } else if (_completedChecklist < _checklist) {
                    Program.userPoints += goal._points;
                    _completedChecklist ++;
                }
            }
        } else {
            Console.WriteLine("You have already completed this goal");
        }
    }
}