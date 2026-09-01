using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = 1;

        while (userNumber != 0)
        {
            Console.Write("Please enter a number (type 0 when finished): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        if (numbers.Count > 0)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Count;

            int largest = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }

            int smallestPositive = 999999999;

            foreach (int number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            
            numbers.Sort();
            Console.WriteLine("The sorted list is: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }


    }
}