using System;

public class Word

{

    // stores the word

    private string _text;

    // checks if hidden

    private bool _isHidden;

    // makes a new word

    public Word(string text)

    {

        _text = text;

        _isHidden = false;

    }

    // hides the word

    public void Hide()

    {

        _isHidden = true;

    }

    // shows the word again

    public void Show()

    {

        _isHidden = false;

    }

    // returns true or false

    public bool IsHidden()

    {

        return _isHidden;

    }

    // shows word or underscores

    public string GetDisplayText()

    {

        if (!_isHidden)

        {

            return _text;

        }

        char[] hiddenText = new char[_text.Length];

        for (int i = 0; i < _text.Length; i++)

        {

            if (char.IsLetter(_text[i]))

            {

                hiddenText[i] = '_';

            }

            else

            {

                hiddenText[i] = _text[i];

            }

        }

        return new string(hiddenText);

    }

}