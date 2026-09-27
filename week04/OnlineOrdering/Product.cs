using System;

public class Product
{
    private string _name;
    private int _productID;
    private float _price;
    private int _quantity;

    public Product(string name, int productID, float price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string PackingLabel()
    {
        return _name + ", Item ID: " + _productID + $", Price per item: ${_price.ToString("F3")}" + " by # of items: " + _quantity;
    }

    public float Cost()
    {
        return _price * _quantity;
    }

    public int ShowQuantity()
    {
        return _quantity;
    }
    public void ChangeQuantity(int newQuantity)
    {
        _quantity = newQuantity;
    }
}