public class Running : Activity {
    decimal _distance;
    public decimal GetDistance() {
        return _distance;
    }
    public Running(string Date, int Length, decimal Distance)
        : base(Date, Length) {
            _distance = Distance;
    }
    public decimal GetSpeed() {
        decimal Speed = (GetDistance() / GetLength()) * 60;
        return Math.Round(Speed,4);
    }
    public decimal GetPace() {
        decimal Pace = 60 / GetSpeed();;
        return Math.Round(Pace, 4);
    }
    public override string GetSummary() {
        return GetDate() + " Running (" + GetLength() + " min) - Distance " + GetDistance() + " miles, Speed " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile";
    }
}


//03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

//public override string showGoal(Goal goal) {
//        ChecklistGoal cg = (ChecklistGoal)goal;
//        //cg.getComplete();
//        return cg.getComplete(_completed) + " " + _name + ": " + _desc + " " + cg.getCompletionProgress(goal);
//}