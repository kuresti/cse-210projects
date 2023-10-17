using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
       // Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
       // Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }

    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
       // Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public void SetTopNumber(int top)
    {
        _topNumber = top;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string answer = $"{_topNumber}/{_bottomNumber}";
        return answer;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_bottomNumber;
    }

}

