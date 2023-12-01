using System;

//Product class contains the product name
//id number, price, and quantity.
public class Product
{
    //Attributes of the Product class
    private string _productName;
    private int _productID;
    private decimal _productPrice;
    private int _productQuantity;

    //Getters and private setters for attributes
    public string ProductName
    {
        get {return _productName;}
        private set {_productName = value;}
    }

    public int ProductID
    {
        get{return _productID;}
        private set{_productID = value;}
    }

    public decimal ProductPrice 
    {
        get {return _productPrice;}
        private set{_productPrice = value;}
    }

    public int ProductQuantity 
    {
        get {return _productQuantity;}
        private set {_productQuantity = value;}
    }

    //Constructor of Product
    public Product(string productName, int productID, decimal productPrice, int productQuantity)
    {
        ProductName = productName;
        ProductID = productID;
        ProductPrice = productPrice;
        ProductQuantity = productQuantity;
    }

    //Method of Product to calculate price of product
    public decimal CalculatePrice()
    {
        _productPrice = _productPrice * _productQuantity;
        return _productPrice;
    }



}