public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double productTotal = 0.0;

        foreach (Product product in _products)
        {
            double singleProductCost = product.CalculateTotalCost();
            productTotal = productTotal + singleProductCost;
        }
        double shippingCost = 35.0;
        if (_customer.LivesInUsa())
        {
            shippingCost = 5.0;
        }

        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- THE PACKING LABEL ---\n";
        foreach (Product product in _products)
        {
            string theProductInfo = $"Product: {product.GetName()} | ID: {product.GetProductId()}\n";

            label = label + theProductInfo;
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- THE SHIPPING LABEL ---\n";
        string theName = $"Name: {_customer.GetName()}\n";
        label = label + theName;

        string theAddress = $"Address:\n{_customer.GetAddress().GetFullAddress()}\n";
        label = label + theAddress;
        
        return label;
    }
}