using System;

public class Reference

{

    // book name

    private string _book;

    // chapter number

    private int _chapter;

    // starting verse

    private int _verse;

    // ending verse

    private int _endVerse;

    // for one verse

    public Reference(string book, int chapter, int verse)

    {

        _book = book;

        _chapter = chapter;

        _verse = verse;

        _endVerse = verse;

    }

    // for verse ranges

    public Reference(string book, int chapter, int startVerse, int endVerse)

    {

        _book = book;

        _chapter = chapter;

        _verse = startVerse;

        _endVerse = endVerse;

    }

    // returns the reference

    public string GetDisplayText()

    {

        if (_verse == _endVerse)

        {

            return $"{_book} {_chapter}:{_verse}";

        }

        return $"{_book} {_chapter}:{_verse}-{_endVerse}";

    }

}