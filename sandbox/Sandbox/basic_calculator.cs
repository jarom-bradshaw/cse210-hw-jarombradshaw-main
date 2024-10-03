// Ideas for improvement from copilot(DO ON YOUR OWN): 
// Handle case error and validate code. Provide a line if the operator given is not an option that an error is running:
// Fixes: Syntax errors(Only use ""/Capitalize Line on ReadLine/use float.Parse(function()),use TryParse for validation)
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        float number_1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Please choose your operator (i.e. +,-,/,*)");
        string operator_1 = Console.ReadLine();
        Console.WriteLine("Please choose a second number:");
        float number_2 = float.Parse(Console.ReadLine());        

        float answer;

        if (operator_1=="+"){
            answer = number_1 + number_2;
            Console.WriteLine($"{answer}");
        }
        else if (operator_1=="-"){
            answer = number_1 - number_2;
            Console.WriteLine($"{answer}");
        }
        else if (operator_1=="*"){
            answer = number_1 * number_2;
            Console.WriteLine($"{answer}");
        }
        else if (operator_1=="/"){
            answer = number_1 / number_2;
            Console.WriteLine($"{answer}");
        }
        }
}