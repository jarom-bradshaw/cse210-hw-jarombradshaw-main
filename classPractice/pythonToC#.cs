using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]

class Program
{
    static void Main(string[] args)
        // Console.WriteLine("What is your comment? "");
        // answer = Console.ReadLine();
        // Console.Write($"Your comment is{answer}");

        List<string> animals = new List<string>();
        animals.Add("sheep");
        animals.Add("cow");
        animals.Add("pig");

        foreach (string animal in animals)

}


        // Creating a List of integers
        // Here we are not setting
        // Capacity explicitly
        List<int> firstlist = new List<int>();

        // adding elements in firstlist
        firstlist.Add(1);
        firstlist.Add(2);
        firstlist.Add(3);
        firstlist.Add(4);

        // Printing the Capacity of firstlist
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);

        // Printing the Count of firstlist
        Console.WriteLine("Count Is: " + firstlist.Count);

        // Adding some more
        // elements in firstlist
        firstlist.Add(5);
        firstlist.Add(6);

        // Printing the Capacity of firstlist
        // It will give output 8 as internally
        // List is resized
        Console.WriteLine("Capacity Is: " + firstlist.Capacity);

        // Printing the Count of firstlist
        Console.WriteLine("Count Is: " + firstlist.Count);
