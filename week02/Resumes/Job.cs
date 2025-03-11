using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} at {_company} from {_startYear} to {_endYear}");
        Job job1 = new Job();
        job1._company = "BYU-Idaho";
        job1._jobTitle = "Student Mentor";
    }
}

