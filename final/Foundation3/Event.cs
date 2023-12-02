using System;

//Base class for the Event Program
public  abstract class Event
{
    //Attributes of the Event class
    //that will be inherited by derived classes
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    //Constructors of the Event class
    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        EventAddress = address;
    }

    public Event(string eventTitle, string date)
    {
        _eventTitle = eventTitle;
        _date = date;
    }

    //Get Set for _address
    public Address EventAddress
    {
        get { return _address;}
        private set {_address = value;}
    }

    //Methods of the Event class
    //that will be inherited by the derived classes

    //Standard Message
    public void DisplayStandardMessage()
    {
        Console.WriteLine($"{_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n{EventAddress.GetAddressString()}");
    }

     //Full Details Message Abstract method
    //will be overridden by derived classes
    public abstract string DisplayFullDetails();
    
    //Short description Message
    public void DisplayShortMessage()
    {
        Console.WriteLine($"{GetType()}\n{_eventTitle}\nDate: {_date}");
    }
}