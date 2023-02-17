using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Going to sleep for a second...");
        Animation animation1 = new Animation();
        animation1.Animate(6); 
        Console.WriteLine("I'm back!!");
    }
}