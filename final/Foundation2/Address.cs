using System;

//Address class holds address string and 
//determines if address is in US or not
public class Address
{
    //Attributes of the Address class
    private string _streetAddress; 
    private string _city; 
    private string _stateOrProvince ;    
    private string _country;
    private bool _USA;
    
    //Public properties with private setters and getter
    public string StreetAddress
    {
        get {return _streetAddress;}
        private set {_streetAddress = value;}
    }

    public string City 
    {
        get {return _city;}
        private set {_city = value;}
    }

    public string StateOrProvince 
    {
        get {return _stateOrProvince;}
        private set {_stateOrProvince = value;}
    }

    public string Country 
    {
        get {return _country;}
        private set {_country = value;}
    }

    //Constructor of the Address class
   public Address(string streetAddress, string city, string stateOrProvince, string country)
    { 
        //Set private properties using private setters
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    //Method to format Address string for a 
    //shipping label in the Order class
    public string GetAddressString()
    {
        return $"{_streetAddress}\n {_city}, {_stateOrProvince}, {_country}";
    }

    //Method to determine if the address is
    //in the USA or not
    public bool GetUSAOrNot()
    {
        
        if (_country == "USA")
        {
            _USA = true;
        }
        else
        {
            _USA = false;
        }
        return _USA;
    }
}