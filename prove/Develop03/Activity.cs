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
        // ThankYouMessage IDK if i need this
        Duration = duration;
    }

    public void StartMessage()
    {
        Console.WriteLine($"Starting activity: {Name}"); // Remember to add description for the starting message
    }

    public void EndMessage()
    {
        Console.WriteLine($"Ending activity: {Name}");
    }


    public void AnimatePause(int seconds)
    {

    }

    // Logic below was created by chatGPT for learning, I will try in my own way.

    // public void AnimatePause(int seconds)
    // {
    //     for (int i = 0; i < seconds; i++)
    //     {
    //         Console.Write("insertwhat I choose later");
    //         System.Threading.Thread.Sleep(1000);
    //     }
    //     Console.WriteLine();
    }
}