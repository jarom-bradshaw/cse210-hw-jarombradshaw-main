using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "lds-scriptures.csv";

        if (!File.Exists(filePath)) // glitches without this I added this line through AI
        {
            Console.WriteLine($"Error: The file '{filePath}' does not exist.");
            return;
        }

        Program program = new Program();
        var scriptures = program.LoadScriptures(filePath);
        program.Start(scriptures);
    }

    private List<Scripture> LoadScriptures(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(',');

            //Extract necessary fields from CSV columns
            string book = parts[5]; // "book_title"
            int chapter = int.Parse(parts[14]); // "chapter_number"
            int verse = int.Parse(parts[15]); // "verse_number"
            string text = parts[16]; // "scripture_text"

            //Create/construct reference and scripture objects.
            Reference reference = new Reference(book, chapter, verse);
            Scripture scripture = new Scripture(reference, text);
            scriptures.Add(scripture);
        }

        return scriptures; //save variable
    }

    private void Start(List<Scripture> scriptures)
    {
        var random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input == "quit") break;

            scripture.HideWords(2); // Hides 2 random words each iteration
        }

        Console.WriteLine("One last try! All words are hidden! The Program will end.");
    }
}
