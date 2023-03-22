
public class Order
{
    private List<Product> _productList= new List<Product>();
    private Customer _customer;

    private double _totalCost = 0;

    public double CalculateTotal()
    {
        foreach (Product product in _productList)
        {
            _totalCost += product.GetTotalPrice();
        }
        if (_customer.IsUsaBased())
        {
            _totalCost += 5.00;
        }
        else
        {
            _totalCost += 35.00;
        }
        return _totalCost;
    
    }
    public string ShippingLabel()
    {
        return _customer.ShippingString();

    }
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach(Product product in _productList)
        {
            label += $"{product.GetPackingString()}\n";
        }
        return label;

    }
    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProductToOrder(Product product)
    {
        _productList.Add(product);
    }




}