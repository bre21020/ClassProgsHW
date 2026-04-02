public class Activity {
    string _date;
    int _length;
    public Activity(string Date, int Length) {
        _date = Date;
        _length = Length;
    }
    public string GetDate() {
        return _date;
    }
    public int GetLength() {
        return _length;
    }
    public virtual string GetSummary() {
        return "Never gonna give you, never gonna let you down, never gonna run around and desert you";
    }
}

//Distance (km) = swimming laps * 50 / 1000
//Distance (miles) = swimming laps * 50 / 1000 * 0.62
//Speed (mph or kph) = (distance / minutes) * 60
//Pace (min per mile or min per km)= minutes / distance
//Speed = 60 / pace
//Pace = 60 / speed


//public override string showGoal(Goal goal) {
//        ChecklistGoal cg = (ChecklistGoal)goal;
//        //cg.getComplete();
//        return cg.getComplete(_completed) + " " + _name + ": " + _desc + " " + cg.getCompletionProgress(goal);
//}

// speed = distance over time
// distance = speed * time