using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("==================================");
        Console.WriteLine();
        Console.WriteLine("========= Math Assignment ========");
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodrigruez", "Fractions", "7.3", "8-19");

        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine("==================================");
        Console.WriteLine();
        Console.WriteLine("======= Writing Assignment =======");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}