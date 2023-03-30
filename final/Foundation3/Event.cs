
public class Event
{
    private string _title;
    protected string _type;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;

    public string StandardDetails()
    {
        return $"Event Details: \nTitle: {_title} \nDescription: {_description} \nDate: {_date} \nTime: {_time} \nAddress: \n{_address.PropertiesToString()}";
    }
    public string ShortDescription()
    {
        return $"Type: {_type} Event \nTitle: {_title} \nDate: {_date}";
    }
    
    public Event(string title, string description, DateOnly date, TimeOnly time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


}