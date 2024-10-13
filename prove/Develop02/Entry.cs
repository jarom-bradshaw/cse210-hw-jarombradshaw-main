using System;
// using System.Collections.Generic; I think Systems should just call everything specifically
// using System.IO;

// This file runs a journal program. It allows you to choose between, adding editing, displaying or deleting entries. 
// It can also save a journal to a file by selecting the file and it will run a file path. If the file does not exist,
// it will make a new one. And it will also clear old entries when restarting the program if not saved to a FilePath. 
// If you do not save, it will only display the most recent entry. It can also quit the program. If put into a csv file, 
// it will properly save your journal entry for a later date to come back and add more. It also saves the day and time 
// that you put into the program

// What I learned(Self reflection): I learned how to better design a program. I learned more about the design process for 
// functions or programs that include multiple paramaters and how to simplify and make the code cleaner. I redid this
// several times.
//

// What I would like to do in future programs.
// I would like to be able to write the file in different files to make it easier to look through.
// I do not know how to do that.
//


// Class representing a journal entry
public class Entry
{
    // Public field for the text of the entry
    public string Text;
    // Public field for the date of the entry
    public DateTime Date;

    // Constructor to initialize the text and date fields
    public Entry(string text, DateTime date)
    {
        Text = text;
        Date = date;
    }

    // Override ToString method to return a formatted string of the entry
    public override string ToString() //I used AI to do the comments and the override part of the code. I do not know how to use this override par
    // I spent a long time trying to get it work and still have a lot of hw to do today. I researched the override and asked AI to explain how it works.
    // It simply gave a very dense explanation i did not understand fully, but I have a basic understanding of how it works.
    {
        return $"{Date.ToShortDateString()}: {Text}";
    }
}

// Class representing the journal which contains multiple entries
public class Journal
{
    // List to store journal entries
    public List<Entry> Entries = new List<Entry>();

    // Method to add a new entry to the journal
    public void AddEntry(string text)
    {
        Entries.Add(new Entry(text, DateTime.Now)); // Uses the public list Class to create a new entry with parameters of text, and DateTime.Now
    }

    // Method to display all journal entries
    public void DisplayJournalEntries()
    {
        foreach (var entry in Entries) //Iterates through the journals with the entry as an index and turns into a string from csv and then pulls into a Console.WriteLine
        {
            Console.WriteLine(entry.ToString());
        }
    }

    // Method to delete an entry by index
    public void DeleteEntry(int index)
    {
        if (index >= 0 && index < Entries.Count)
        {
            Entries.RemoveAt(index);
            SaveEntriesToFile();
        }
        else
        {
            Console.WriteLine("Invalid entry index.");
        }
    }

    // Method to save all entries to a file and quit the application
    public void Quit()
    {
        SaveEntriesToFile();
        Console.WriteLine("Exiting the journal application.");
        Environment.Exit(0);
    }

    // Private method to save all entries to a CSV file
    private void SaveEntriesToFile()  // Is this the correct way to use private?
    {
        string filePath = "JournalEntry.csv";
        // Check if the file exists, if not, create it
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }

        // Prepare the lines to be written to the file
        List<string> lines = new List<string>();
        foreach (var entry in Entries)
        {
            lines.Add($"{entry.Date},{entry.Text}");
        }

        // Write all lines to the file
        File.WriteAllLines(filePath, lines);
    }

    public void EditEntry(int index, string newText)
    {
        if (index >= 0 && index < Entries.Count)
        {
            Entries[index+1].Text = newText; // index +1 to help people who do not understand indexes
        }
        else
        {
            Console.WriteLine("Invalid entry index.");
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))  //I do not understand the StreamWriter very well. Online it says it is part of 
        // the I.O. and it helps you use this function to write it. How would I make a custom csv reader file. What I understand is that this 
        // essentially changes the path for this function so that instead of writing it here, it writes it in the csv on the file path is that correct?
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Text}");
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        Entries.Clear(); //Clears the current list of entries to ensure we only have the data from the file.
        using (StreamReader reader = new StreamReader(filePath)) //Opens the file specified by filePath for reading. StreamReader is used to read text from the file.
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(','); //Splits the line by commas. This assumes each line is in the format date,text.
                if (parts.Length == 2) // assumes the line is in the format date,text. I could create more complex conditions if I had more information in the parts.
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string text = parts[1];
                    Entries.Add(new Entry(text, date));
                    //Parses the date and text parts. 
                    //Creates a new Entry object with the parsed date and text.
                    // Adds the new entry to the Entries list. 
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the Journal class
        Journal journal = new Journal();
        // Boolean flag to control the while loop
        bool running = true;

        // Loop until the user chooses to quit and makes the user interface (UI)
        while (running)
        {
            // Display the menu options to the user
            Console.WriteLine("Journal Application");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Edit Entry");
            Console.WriteLine("4. Delete Entry");
            Console.WriteLine("5. Save to File");
            Console.WriteLine("6. Load from File");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option: ");

            // Read the user's input and parse it as an integer
            int option = int.Parse(Console.ReadLine());

            // Check which option the user selected
            if (option == 1)
            {
                // Prompt the user to enter a journal entry
                Console.Write("Enter your journal entry: ");
                // Read the user's journal entry
                string entryText = Console.ReadLine();
                // Add the entry to the journal
                journal.AddEntry(entryText);
            }
            else if (option == 2)// If user selects 2, fulfill that function
            {
                journal.DisplayJournalEntries();
            }
            else if (option == 3) // If user selects 3, fulfill that function
            {
                Console.Write("Enter the index of the entry to edit: ");
                int editIndex = int.Parse(Console.ReadLine()); // choose the index to rewrite over journal file. How could I use a 
                // function to directly edit parts of a cell and not all of it. What else could I add to know how to search for a journal.
                Console.Write("Enter the new text: ");
                string newText = Console.ReadLine();
                journal.EditEntry(editIndex, newText);
            }
            else if (option == 4)
            {
                Console.Write("Enter the index of the entry to delete: ");
                int deleteIndex = int.Parse(Console.ReadLine());
                journal.DeleteEntry(deleteIndex);
            }
            else if (option == 5)
            {
                Console.Write("Enter the file path to save to: ");
                string savePath = Console.ReadLine();
                journal.SaveToFile(savePath);
            }
            else if (option == 6)
            {
                Console.Write("Enter the file path to load from: ");
                string loadPath = Console.ReadLine();
                journal.LoadFromFile(loadPath);
            }
            else if (option == 7)
            {
                running = false; // uses an else condition to quit. I think something good would be to find a way to quit the program if someone tries to but is unable too, 
                // but I think that this logic for this loop is correct.
                journal.Quit();
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}


// public void SearchEntries(string substring) FROM AI: Put here to learn how to do it. But became confused on the for loop
// {
//     bool found = false;
//     for (int i = 0; i < Entries.Count; i++)
//     {
//         if (Entries[i].Text.Contains(substring, StringComparison.OrdinalIgnoreCase))
//         {
//             Console.WriteLine($"Entry {i}: {Entries[i]}");
//             found = true;
//         }
//     }

//     if (!found)
//     {
//         Console.WriteLine("No entries found containing the substring.");
//     }
// }

// Console.Write("Enter the substring to search for: ");
//         string substring = Console.ReadLine();
//         journal.SearchEntries(substring);
//     }