using System;

class Program
{
    static void Main(string[] args)
    {
        DateOnly date = new DateOnly(2023,7,12);
        Running running = new Running(date,60,10);
        Swimming swimming = new Swimming(date,30,20);
        Cycling cycling = new Cycling(date,75,15);
        List<Activity> activities = new List<Activity>(){running,swimming,cycling};
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}