using System;

public class Activity
{
    public string Name;
    public string Description;
    public int Duration;

    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Starting activity: {Name}");
    }

    public void EndMessage()
    {
        Console.WriteLine($"Ending activity: {Name}");
    }

    public void AnimatePause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("insertwhat I choose later");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}