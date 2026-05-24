using System;

using System.Collections.Generic;

class Program

{

    static void Main(string[] args)

    {

        // extra feature:

        // program picks a random scripture

        List<Scripture> scriptures = new List<Scripture>

        {

            new Scripture(

                new Reference("John", 3, 16),

                "For God so loved the world that he gave his only begotten Son"

            ),

            new Scripture(

                new Reference("Proverbs", 3, 5, 6),

                "Trust in the Lord with all thine heart and lean not unto thine own understanding"

            ),

            new Scripture(

                new Reference("1 Nephi", 3, 7),

                "I will go and do the things which the Lord hath commanded"

            )

        };

        Random random = new Random();

        // picks one scripture

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        // keeps running until done

        while (true)

        {

            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            // stop if fully hidden

            if (scripture.IsCompletelyHidden())

            {

                break;

            }

            Console.WriteLine();

            Console.Write("Press enter or type quit: ");

            string input = Console.ReadLine();

            // stops program

            if (input.ToLower() == "quit")

            {

                break;

            }

            // hides 3 words

            scripture.HideRandomWords(3);

        }

    }

}