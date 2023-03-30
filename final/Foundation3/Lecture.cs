public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public string FullDetails()
    {
        string startString = base.StandardDetails();
        return $"Full {startString} \nCapacity: {_capacity} \nSpeaker: {_speaker}";

    }
    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity): base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _type = "Lecture";
    }

}