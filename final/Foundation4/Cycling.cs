public class Cycling : Activity {
    decimal _speed;
    public decimal GetSpeed() {
        return _speed;
    }
    public Cycling(string Date, int Length, decimal Speed)
        : base(Date, Length) {
            _speed = Speed;
    }
    public decimal GetDistance() {
        decimal Distance = GetSpeed() * GetLength();
        return Math.Round(Distance, 4);
    }
    public decimal GetPace() {
        decimal Pace = GetLength() / GetDistance();
        return Math.Round(Pace, 4);
    }
    public override string GetSummary() {
        return GetDate() + " Cycling (" + GetLength() + " min) - Distance " + GetDistance() + " miles, Speed " + GetSpeed() + " mph, Pace: " + GetPace() + " min per mile";
    }
}


//03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile

//public override string showGoal(Goal goal) {
//        ChecklistGoal cg = (ChecklistGoal)goal;
//        //cg.getComplete();
//        return cg.getComplete(_completed) + " " + _name + ": " + _desc + " " + cg.getCompletionProgress(goal);
//}