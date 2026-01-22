using System;
public class Job {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display() {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

public class Resume {
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display() {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs:");
        for (int i = 0; i < _jobs.Count; i++) {
            _jobs[i].Display();
            //Console.WriteLine(_jobs.Count);
        }
    }
}