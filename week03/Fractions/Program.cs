using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(defaultFraction.GetDecimalValue());

        Fraction numerator = new Fraction(5);
        Console.WriteLine(numerator.GetFractionString());
        Console.WriteLine(numerator.GetDecimalValue());

        Fraction fraction = new Fraction(3, 4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        Fraction newFraction = new Fraction(1, 3);
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());

        Console.WriteLine("\n----- Testing Getters and Setters -----");

        Fraction testFraction = new Fraction();

        testFraction.SetTop(6);
        testFraction.SetBottom(7);

        Console.WriteLine($"Top value using GetTop(): {testFraction.GetTop()}");
        Console.WriteLine($"Bottom value using GetBottom(): {testFraction.GetBottom()}");
        Console.WriteLine($"Fraction using Getter and Setter: {testFraction.GetFractionString()}");
        Console.WriteLine($"Fraction decimal using Getter and Setter: {testFraction.GetDecimalValue()}");
    }
}