public class Reception : Event
{
    private string _rsvpEmail;


    public string FullDetails()
    {
        string startString = base.StandardDetails();
        return $"Full {startString} \nRSVP Email: {_rsvpEmail}";
    }
    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string rsvpEmail): base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _type = "Recepetion";

    }
}