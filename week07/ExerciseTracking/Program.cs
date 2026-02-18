using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> newList = new List<Activity>();
        
        Running newRun = new Running(65, 5);
        Cycling newCycle = new Cycling(30, 60);
        Swimming newSwim = new Swimming(60, 45);
        newList.Add(newRun);
        newList.Add(newCycle);
        newList.Add(newSwim);
        newList.ForEach(activity => Console.WriteLine($"{activity} - {activity.GetSummary()}"));
    }
}

