
public class ChecklistGoal : Goal
{
    private string _timesCompleted = "0";

    private string _totalTimes;
    private int _bonus;
    
    public override int CompleteGoal()
    {
        int compareTimesCompleted = int.Parse(_timesCompleted);
        int compareTotalTimes = int.Parse(_totalTimes);
        compareTimesCompleted += 1;
        _timesCompleted = $"{compareTimesCompleted}";
        if (compareTimesCompleted < compareTotalTimes)
        {
            return _points;
        }
        else
        {
            int bothPoints = _points + _bonus;
            _isComplete = true;
            _checkBox = "[X]";
            return bothPoints;
        }
        
    }
    public override string PrintGoalAsString()
    {
        return $"{_type}, {_name}, {_description}, {_points}, {_bonus}, {_totalTimes}, {_timesCompleted}";
    }
    public override void Display()
    {
        Console.WriteLine($"{_checkBox} {_name} ({_description}) --- Currently Completed {_timesCompleted}/{_totalTimes}");
    }
    public ChecklistGoal()
    {
        _type = "Checklist Goal";
    }
    public ChecklistGoal(string name, string description, int points, string totalTimes, int bonus): base(name, description, points)
    {
        _type = "Checklist Goal";
        _totalTimes = totalTimes;
        _bonus = bonus;

    }
    public void SetTimesCompleted(string times)
    {
        _timesCompleted = times;
        
    }


}