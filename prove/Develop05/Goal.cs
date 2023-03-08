
public abstract class Goal
{
    protected string _type; 
    protected string _name;

    protected string _description;
    protected bool _isComplete; 
    protected string _checkBox = "[ ]";
    protected int _points;

    public virtual int CompleteGoal()
    {
        return _points;
    }
    public virtual string PrintGoalAsString()
    {
        return $"{_type}, {_name}, {_description}, {_points}";
    }
    public virtual void Display()
    {
        
    }
    public Goal()
    {

    }
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public string GetName()
    {
        return _name;
    }
    public bool GetCompleteStatus()
    {
        return _isComplete;
    }
    

}