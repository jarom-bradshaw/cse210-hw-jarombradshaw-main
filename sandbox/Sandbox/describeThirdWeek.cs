using System;

class Box
{
    public double length = 0;
    public double height = 0;
    public double width = 0;
    public string unit = "";

    public string describe()
    {
        return $"Box {length}x{width}x{height} {unit}";
    }

    public double volume()
    {
        return length * width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. View Entries");
            Console.WriteLine("3. Edit Entry");
            Console.WriteLine("4. Delete Entry");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int option))
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Adding a new entry...");
                        // Add entry logic here
                        break;
                    case 2:
                        Console.WriteLine("Viewing all entries...");
                        // View entries logic here
                        break;
                    case 3:
                        Console.WriteLine("Editing an entry...");
                        // Edit entry logic here
                        break;
                    case 4:
                        Console.WriteLine("Deleting an entry...");
                        // Delete entry logic here
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}
