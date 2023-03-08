
public class EternalGoal : Goal
{
    public override void Display()
    {
        Console.WriteLine($"{_checkBox} {_name} ({_description})");
    }
    public EternalGoal()
    {
        _type = "Eternal Goal";
    }
    public EternalGoal(string name, string description, int points): base(name, description, points)
    {
        _type = "Eternal Goal";
    }


}