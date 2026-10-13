using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running("11 Oct 2026", 30, 3.0);
        Cycling cyclingActivity = new Cycling("12 Oct 2026", 45, 15.0);
        Swimming swimmingActivity = new Swimming("13 Oct 2026", 20, 20);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}