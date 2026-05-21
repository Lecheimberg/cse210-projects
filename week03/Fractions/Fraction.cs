using System;
public class Fraction
{
    // top number
    private int _top;

    // bottom number
    private int _bottom;

    //  1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 5/1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 3/4
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // gets the top number
    public int GetTop()
    {
        return _top;
    }

    // gets the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // changes the top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // changes the bottom number
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // gives the fraction like 3/4
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // gives the decimal like 0.75
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}