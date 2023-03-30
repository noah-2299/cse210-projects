public class Cycling : Activity
{
    private double _speed;

    public override double CalculateDistance()
    {
        return (_speed / 60) * _duration;
    }
    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return _duration / distance;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public Cycling(DateOnly date, double duration, double speed) :base(date, duration)
    {
        _type = "Cycling";
        _speed = speed;
    }
}