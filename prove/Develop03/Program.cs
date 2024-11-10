using System; // Namespace import
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates; // Namespace import

namespace Develop03
{
    class Program
    {
        private List<string> activities; // Private instance variable of type List<string>

        public Program()
        {
            activities = new List<string>(); // Initializing the List<string> object
        }

        public void Run()
        {
            // Logic will go here
        }


        static void Main(string[] args) // Static method
        {
            Program program = new Program(); // Creating an instance of Program
            program.Run(); // Calling the Run method on the instance
        }
    }
}