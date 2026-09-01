using System;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        DisplayWelcome();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        string UserName = PromptUserName();


        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        int MyFavoriteNumber = PromptUserNumber();


        static int SquareNumber(int number)
        {
            return number * number;
        }
        int MySquareNumber = SquareNumber(MyFavoriteNumber);


        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }

        DisplayResult(UserName, MySquareNumber);

    }
}