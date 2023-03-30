public class Running : Activity
{
    private double _distance;

    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculatePace()
    {
        return _duration /_distance;
    }
    public override double CalculateSpeed()
    {
        return _distance / (_duration / 60); 
    }
    public Running(DateOnly date, double duration, double distance) :base(date, duration)
    {
        _type = "Running";
        _distance = distance;
    }
}