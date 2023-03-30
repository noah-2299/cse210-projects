public class Outdoor : Event
{
    private string _weatherAdvisory;
    public Outdoor(string title, string description, DateOnly date, TimeOnly time, Address address, string weatherAdvisory): base(title, description, date, time, address)
    {
        _weatherAdvisory = weatherAdvisory;
        _type = "Outdoor";
    } 
    public string FullDetails()
    {
        string startString = base.StandardDetails();
        return $"Full {startString} \nExpected Weather: {_weatherAdvisory}";
    }
}