using System; // Namespace import
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates; // Namespace import

namespace Develop03
{
    class Program
    {
        private List<Activity> activities; // Private instance variable of type List Activity. Was <string> at first, but I changed it.

        public Program()
        {
            activities = new List<Activity>(); // Initializing the List<Activity> object. Was string beforehand.
        }

        public void Run()
        {
            // Construct any items
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Excercise", "A simple breathing excercise", 5);
            activities.Add(breathingActivity);
        
            // logic to run the activities

            
        }


        static void Main(string[] args) // Static method
        {
            Program program = new Program(); // Creating an instance of Program
            program.Run(); // Calling the Run method on the instance
        }
    }
}

//  inhale duration
//  exhale duration

// animatepause use a dictionary and use a star 
//    /\
// __/  \__
// \      /
// /_    _\
//   \  /
//    \/

//    /\
// ___/\___
// \      /
// /__  __\
//    \/
//    \/