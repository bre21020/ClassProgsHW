using System;

class ChecklistGoal : Goal {
    //public string _type = "";
    
    public ChecklistGoal(string name, string desc, int points, string type, int checklist, int bonusPoints) {
        _name = name;
        _desc = desc;
        _points = points;
        _type = type;
        _checklist = checklist;
        _bonus = bonusPoints;
    }
    public override string showGoal(Goal goal) {
        ChecklistGoal cg = (ChecklistGoal)goal;
        //cg.getComplete();
        return cg.getComplete(_completed) + " " + _name + ": " + _desc + " " + cg.getCompletionProgress(goal);
    }
    
}