public class Swimming : Activity
{
    private int _numLaps;

    public override double CalculateDistance()
    {
        return (_numLaps * 50) / 1000;
    }
    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return _duration / distance;
    }
    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        return distance / (_duration / 60);
    }
    public Swimming(DateOnly date, double duration, int numLaps) :base(date, duration)
    {
        _type = "Swimming";
        _numLaps = numLaps;
    }
}
