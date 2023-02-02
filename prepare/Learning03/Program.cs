using System;

class Program
{
    static void Main(string[] args)
    {
        int top = 6;
        int bottom = 7;

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(top);
        Fraction f3 = new Fraction(top,bottom);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetFractionString());
    }
}