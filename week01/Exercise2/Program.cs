using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade in %:");
        int percentage = int.Parse(Console.ReadLine());

        string GPA = "";
        if (percentage >= 90)
        {
            GPA = "A";
        }
        else if (percentage >= 80)
        {
            GPA = "B";
        }
        else if (percentage >= 70)
        {
            GPA = "C";
        
        }
        else if (percentage >= 60)
        {
            GPA = "D";
        }
        else
        {
            GPA = "F";
        }

        string sign = "";
        int lastDigit = percentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        if (GPA == "A" && sign == "+")
        {
            sign = "";
        }
        if (GPA == "F")
        {
            sign = " ";
        }
        Console.WriteLine($"Your grade is: {GPA}{sign}");

        if (percentage >= 70)
        {
        Console.WriteLine("Congrats! You passed the course");
        }
        else
        {
            Console.WriteLine("Don't give up! You'll do better next time.");
        }

    }
}