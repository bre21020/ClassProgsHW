using System;

class SimpleGoal : Goal {
    //public string _type = "";
    
    public SimpleGoal(string name, string desc, int points, string type) {
        _name = name;
        _desc = desc;
        _points = points;
        _type = type;
    }
    
}