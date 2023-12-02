using System;

//Base class for the Event Program
public class Event
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
    public string DisplayStandardMessage(string eventTitle, string description, string date, string time, Address address)
    {
        return $"{eventTitle}\n{description}\n{date}, {time}\n{address}";
    }

    //Short description Message
    public string DisplayShortMessage(string eventTitle, string date)
    {
        return $"{GetType()}\n{eventTitle}, {date}";
    }

    //Full Details Message Abstract method
    //will be overridden by derived classes
    public abstract string DisplayFullDetails();


    



}