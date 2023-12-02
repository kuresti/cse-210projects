using System;

//Address Class contains address details
public class Address
{
    //Attributes of Address class
    private string _streetAddress;
    private string _city;
    private string _state;

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

    public string State 
    {
        get {return _state;}
        private set {_state = value;}
    }

    //Constructor of the Address class
   public Address(string streetAddress, string city, string state)
    { 
        //Set private properties using private setters
        StreetAddress = streetAddress;
        City = city;
        State = state;
        
    }
    
    //Method to get Address string
    public string GetAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_state}";
    }

}