using System;

//Outdoor Gathering class
//derived from Event class
public class OutdoorGatheringEvent : Event
{
    //Attributes of OutdoorGatheringEvent
    private string _weather;

    //Constructors for OutdoorGatheringEvent

    //Standard Message
    public OutdoorGatheringEvent(string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {}

    //Constructor for full details
    public OutdoorGatheringEvent(string eventTitle, string description, string date, string time, string weather, Address address) :base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    //Constructor for short message
    public OutdoorGatheringEvent(string eventTitle, string date) :base(eventTitle, date)
    {}

    //override method derived from Event
    public override string DisplayFullDetails()
    {
        return $"{GetType()}\n{_eventTitle}\n{_description}\n{_date} {_time}\n{_weather}\n{EventAddress.GetAddressString()}";
    }
}