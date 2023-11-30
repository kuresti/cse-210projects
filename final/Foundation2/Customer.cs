using System;

//Customer class contains the customer name
//and address from the Address class. A method
//is called on the _address attribute to determine
//if the customer lives in the USA or not.
public class Customer
{
    //Customer attributes
    private string _name;

    private Address _address;

    //public getter and private setters
    public Address MailingAddress
    {
        get { return _address;}
        private set {_address = value;}
    }

    public string Name
    {
        get {return _name;}
        private set {_name = value;}
    }

    //Constructor for Customer
    public Customer(string name, Address address)
    {
        Name = name;
        MailingAddress = address;
    }

    //Method called on _address to determine
    //if the customer lives in the USA or not
    public bool DomesticOrNot()
    {
        return _address.GetUSAOrNot();
    }
}