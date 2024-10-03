using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        string userGuess = "";
        int userNumber = 0;

        while (userNumber != number)
        // How can I use Try to handle for user error if the input is not an interger? Can I use TryParse?
        {
            Console.WriteLine("What is the magic number? ");
            
            userGuess = Console.ReadLine();
            userNumber = int.Parse(userGuess);

            if (userNumber < number)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userNumber > number)
            { 
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.Write("Congratulations! You guessed the magic number. ");
            }
        }
    }
}