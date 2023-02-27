using System;

public class Rectanlge : Shape
{
    private double _length;
    private double _width;


    public override double GetArea()
    {
        return _length * _width;
    }
    public Rectanlge(string color, double len, double width): base(color)
    {
        _length = len;
        _width = width;
    }
}
