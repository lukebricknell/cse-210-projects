using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1,2);
        Console.WriteLine(f1.ToFraction());
        Console.WriteLine(f1.ToDouble());
    }
}

public class Fraction 
{ 
    private int _top;
    private int _bottom;

    public Fraction() 
    {
        _top = 10;
        _bottom = 10;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    private int GetTop()
    {
        return _top;
    }

    private int GetBottom() 
    {
        return _bottom;
    }

    public string ToFraction()
    {
        string fraction = $"{GetTop()}/{GetBottom()}";
        return fraction;
    }

    public double ToDouble()
    {
        int top = GetTop();
        int bottom = GetBottom();
        double answer = (Double)top / (Double)bottom;
        return answer;
    }

}