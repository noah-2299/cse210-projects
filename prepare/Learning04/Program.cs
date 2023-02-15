using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment science1 = new Assignment("Joshua","Biology");
        Console.WriteLine(science1.GetSummary());

        MathAssignment math1 = new MathAssignment("Section 12","Problems 1-10 odds", "Selena","Algebra");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment test = new WritingAssignment("The Causes of World War II","Billy Bob","European History");
        Console.WriteLine(test.GetSummary());
        Console.WriteLine(test.GetWritingInformation());
    }
}