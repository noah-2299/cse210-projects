using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue", 5);
        Rectanlge r = new Rectanlge("green", 3, 7);
        Cirlce c = new Cirlce("red", 12);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape x in shapes)
        {
            string color = x.GetColor();
            double area = x.GetArea();
            Console.WriteLine($"The shape is made of {color} paper and has an area of {area}!");
        }

    }
}