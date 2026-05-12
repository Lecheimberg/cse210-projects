using System;

using System.Collections.Generic;

class Program

{

    static void Main(string[] args)

    {

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)

        {

            Console.Write("Enter number: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))

            {

                if (num == 0)

                {

                    break;

                }

                numbers.Add(num);

            }

            else

            {

                Console.WriteLine("Invalid input. Please enter a number.");

            }

        }

        if (numbers.Count == 0)

        {

            Console.WriteLine("No numbers entered.");

            return;

        }

        int sum = 0;

        foreach (int number in numbers)

        {

            sum += number;

        }

        double average = (double)sum / numbers.Count;

        int max = numbers[0];

        foreach (int number in numbers)

        {

            if (number > max)

            {

                max = number;

            }

        }

        Console.WriteLine($"The sum is: {sum}");

        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {max}");

        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)

        {

            if (number > 0 && number < smallestPositive)

            {

                smallestPositive = number;

            }

        }

        if (smallestPositive != int.MaxValue)

        {

            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        }

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)

        {

            Console.WriteLine(number);

        }

    }

}