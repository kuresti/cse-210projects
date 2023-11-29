using System;

//Address class holds address string and 
//determines if address is in US or not
public class Address
{
    //Attributes of the Address class
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    //Constructor of the Address class
   public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        // Console.WriteLine($"{streetAddress}");
        // Console.WriteLine($"{city}, {stateOrProvince}, {country}");
    }

    //Method to format Address string for a 
    //shipping label in the Order class
    public void GetAddressString()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}, {_stateOrProvince}, {_country}");
    }
}