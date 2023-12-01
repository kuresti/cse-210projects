using System;
using System.Linq;
using System.Collections.Generic;

//Order class contains a product list and
//a customer. Calculates total of order,
//returns packing label and shipping label
public class Order
{
    //Order class attributes
    private decimal _totalCost = 0;
    private decimal _totalPrice;
    private decimal _shippingCost;
    private Customer _customer;
    //private List<Product> _products;

    //Create instance of List<Product
    private List<Product> _products = new List<Product>();

    //Constructor of Order
    public Order(Customer customer)
    {
        OnlineCustomer = customer;
    }

    //Get and private set for _customer
    public Customer OnlineCustomer
    {
        get {return _customer;}
        private set {_customer = value;}
    }    

    //Methods of the Order class
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public void CalculateTotalCost()
    {
        //Get ProductPrice
        // foreach(Product product in _products)
        // {
        //     decimal price = product.productPrice;
        //     int quantity = product.productQuanity;
        //     decimal calulatedPrice = product.CalculatePrice();
        // }
        //Getting sum of all product prices in
        //an order
        foreach(Product product in _products)
        {
            _totalCost += product.ProductPrice;
        }

        //Getting the shipping charge
        if(_customer.DomesticOrNot() == true)
        {
            _shippingCost = 5.00m;
        }
        else
        {
            _shippingCost = 35.00m;
        }

        //Getting _totalPrice of an order
        _totalPrice = _shippingCost +_totalCost;

        Console.WriteLine($"Total Cost of Order: ${_totalPrice}");
        
    }

    //Packing label method
    public void GetPackingLabel()
    {
        Console.WriteLine("Rosie's Boutique Packing Label");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.ProductName}, ID#: {product.ProductID}");
        }
        Console.WriteLine("");
    }

    //Shipping Label
    public void GetShippingLabel()
    {
        Console.WriteLine($"Shipping Label:\n{OnlineCustomer.Name}\n{OnlineCustomer.MailingAddress.GetAddressString()}\n");
    }


}