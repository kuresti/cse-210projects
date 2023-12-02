using System;

//Address Class contains address details
public class Address
{
    //Attributes of Address class
    private string _streetAddress;
    private string _city;
    private string _state;

    //Constructor or Address
    public Address(string streetAddress, string city, string state)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
    }
    
    //Method to get Address string
    public string GetAddressString()
    {
        return $"{_streetAdress}\n{_city}, {_state}";
    }

}