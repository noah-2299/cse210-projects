public class Product
{
    private string _name;
    private string _productId;
    private double _piecePrice; 
    private int _quantity;
    private double _totalPrice;

    public string GetPackingString()
    {
        return $"{_name}, ID: {_productId} X {_quantity} = {_totalPrice}";
    }

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _piecePrice = price;
        _quantity = quantity;
        _totalPrice = price * quantity;
    }
    public double GetTotalPrice()
    {
        return _totalPrice;
    }
}