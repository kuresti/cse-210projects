using System;

//Reception Event Class
//Derived from Event Class
public class ReceptionEvent : Event
{
    // Attributes of ReceptionEvent
    private string _email;

    //Constructors for ReceptionEvent
    
    //Constructor for StandardMessage
    public ReceptionEvent(string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {}

    //Constructor for Full Details Message
    public ReceptionEvent(string eventTitle, string description, string date, string time, Address address, string email) :base(eventTitle, description, date, time, address)
    {
        _email = email;
    }

    //Constructor for Short Message
    public ReceptionEvent(string eventTitle, string date) :base(eventTitle, date)
    {}

    //ReceptionEvent override of DisplayFullDetails
    //derived from abstract DisplayFullDetails in Event

    public override string DisplayFullDetails()
    {
        return $"{GetType()}\n{_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n{EventAddress.GetAddressString()}\nPlease send your RSVP to {_email}";
    }
}