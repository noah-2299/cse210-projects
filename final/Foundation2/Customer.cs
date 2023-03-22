public class Customer
{
    private string _name;

    private Address _address;

    public bool IsUsaBased()
    {
        return _address.IsUsaBased();
    }
    public string ShippingString()
    {
        return $"{_name},\n{_address.FullString()}";
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}