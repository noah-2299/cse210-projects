
public class SimpleGoal : Goal
{
    
    public override int CompleteGoal()
    {   
        _checkBox = "[X]";
        _isComplete = true;
        return _points;
    }
    public override string PrintGoalAsString()
    {
        return $"{_type}, {_name}, {_description}, {_points}, {_isComplete}";
    }
    public override void Display()
    {
        Console.WriteLine($"{_checkBox} {_name} ({_description})");
    }
    public SimpleGoal()
    {
        _type = "Simple Goal";
    }
    public SimpleGoal(string name, string description, int points): base(name, description, points)
    {
        _type = "Simple Goal";
    }


}