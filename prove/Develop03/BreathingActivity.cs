using System; 

public class BreathingActivity : Activity
{
    // Constructor that calls the base class constructor
    public BreathingActivity(string name, string description, int duration)
    : base(name, description, duration)
    {
    }

    // Method to run the breathin activity
    public void runBreathing()
    { 
        // Logic to run the breathing activity
    }

    // Method to display the message. Will be called in RunBreathing
    public void displayMessage()
    {
        // Logic to display a message
    }
}
