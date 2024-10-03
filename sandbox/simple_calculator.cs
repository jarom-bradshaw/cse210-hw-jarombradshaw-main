using system;

class Program;
{
    static void Main(string[] args);
    {
        Console.WriteLine('Please enter a number:');
        float number_1 = Console.Readline();
        Console.WriteLine('Please choose your operator (i.e. +,-,/,*)');
        string operator_1 = Console.Readline();
        Console.WriteLine('Please choose a second number:');
        float number_2 = Console.Readline();        

        float answer = 

        if (answer=="+"){
            answer = number_1 + number_2;
            Console.WriteLine($"{answer}");
        }
        else if (answer=="-"){
            answer = number_1 - number_2;
            Console.WriteLine($"{answer}");
        }
        else if (answer=="*"){
            answer = number_1 * number_2;
            Console.WriteLine($"{answer}");
        }
        else if (answer=="/"){
            answer = number_1 / number_2;
            Console.WriteLine($"{answer}");
        }
        }
}