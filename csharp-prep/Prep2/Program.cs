using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float gradePercentage = float.Parse(userInput);
        string gradeValue = " ";
        float gradePlusOrMinus = gradePercentage % 10;
        string gradePlusOrMinusString = "";

        if (gradePercentage >= 90)
        {
            gradeValue = "A";
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            gradeValue = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            gradeValue = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            gradeValue = "D";
        }
        // Put a -10 as lower limit in case of late penalties for a grade that could actually be below 0.
        else if (gradePercentage >= -10 && gradePercentage < 60)
        {
            gradeValue = "F";
        }
        else
        {
            Console.Write("Please put in a valid grade between 0 and a 100");
        }

        if (gradePlusOrMinus <3 && gradePlusOrMinus >=0 )
        {
            gradePlusOrMinusString = "-";
        }
        else if (gradePlusOrMinus >= 3 && gradePlusOrMinus <7)
        {
            gradePlusOrMinusString ="";
        }
        else if (gradePlusOrMinus >= 7)
        {
            gradePlusOrMinusString = "+";
        }
        else
        {
            Console.Write("You have made an error. Please enter a grade value between 0 and a 100. If your grade is above a 100, please put 100.");
        }



        Console.Write($"You have a {gradeValue}{gradePlusOrMinusString}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else{
            Console.WriteLine("Better luck next time!");
        }
    }
}