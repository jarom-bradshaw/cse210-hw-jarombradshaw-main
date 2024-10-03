using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string second_name = Console.ReadLine();
        Console.Write($"Your name is {second_name}, {first_name} {second_name}.");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}