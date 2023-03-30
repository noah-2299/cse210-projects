public class Activity
{
    protected string _type;
    protected DateOnly _date;
    protected double _duration;

    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculatePace()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    
    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_type} ({_duration} min)- Distance: {CalculateDistance()} km, Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
    public Activity(DateOnly date, double duration)
    {
        _date = date;
        _duration = duration;
    }
}