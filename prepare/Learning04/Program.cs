using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the Assignment base class
        Assignment simpleAssignment = new Assignment("Josh Rodgers", "Subtraction");
        Console.WriteLine(simpleAssignment.GetSummary());

        // Testing the MathAssignment derived class
        MathAssignment mathAssignment = new MathAssignment("Martha Mandola", "English", "7.8", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Testing the WritingAssignment derived class
        WritingAssignment writingAssignment = new WritingAssignment("Jackson Jones", "English", "Proper Syntax Structure");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
