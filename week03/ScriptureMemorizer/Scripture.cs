using System;

using System.Collections.Generic;

public class Scripture

{

    // stores the reference

    private Reference _reference;

    // stores all words

    private List<Word> _words;

    // random number generator

    private static Random _random = new Random();

    // makes a scripture

    public Scripture(Reference reference, string text)

    {

        _reference = reference;

        _words = new List<Word>();

        // splits text into words

        string[] parts = text.Split(' ');

        // adds words into the list

        foreach (string part in parts)

        {

            _words.Add(new Word(part));

        }

    }

    // hides random words

    public void HideRandomWords(int numberToHide)

    {

        List<Word> visibleWords = new List<Word>();

        // finds visible words

        foreach (Word word in _words)

        {

            if (!word.IsHidden())

            {

                visibleWords.Add(word);

            }

        }

        // stop if all hidden

        if (visibleWords.Count == 0)

        {

            return;

        }

        // prevents errors

        if (numberToHide > visibleWords.Count)

        {

            numberToHide = visibleWords.Count;

        }

        // hides random words

        for (int i = 0; i < numberToHide; i++)

        {

            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);

        }

    }

    // shows the scripture

    public string GetDisplayText()

    {

        string result = "";

        foreach (Word word in _words)

        {

            result += word.GetDisplayText() + " ";

        }

        return _reference.GetDisplayText() + "\n\n" + result;

    }

    // checks if everything is hidden

    public bool IsCompletelyHidden()

    {

        foreach (Word word in _words)

        {

            if (!word.IsHidden())

            {

                return false;

            }

        }

        return true;

    }

}