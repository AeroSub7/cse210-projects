using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = new List<Product>();
        _products = products;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float TotalCost()
    {


        return OrderCost() + ShippingCost();
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label = label + "\n" + product.PackingLabel();
        }
        return label;
    }
    public string ShippingLabel()
    {
        return _customer.Label();
    }
    private float OrderCost()
    {
        float ordercost = 0;
        foreach (Product product in _products)
        {
            ordercost = ordercost + product.Cost();
        }
        return ordercost;
    }
    private int ShippingCost()
    {
        if (_customer.InUSA() == true)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}