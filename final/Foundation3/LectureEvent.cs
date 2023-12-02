using System;

//LectureEvent class derived from 
//Event class
public class LectureEvent : Event
{
    //Attributes of LectureEvent
    private string _speaker;
    private int _capacity;

    //Constructors of LectureEvent
    //Constructor for Standard message
    public LectureEvent(string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {}

    //Constructor for Full Details
    public LectureEvent(string eventTitle, string speaker, string description, int capacity, string date, string time, Address address) :base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //Constructor for ShortMessage
    public LectureEvent(string eventTitle, string date) : base(eventTitle, date)
    {}

    
    //Abstract Method from Event. 
    //Overridden by LectureEvent
    public override string DisplayFullDetails()
    {
        return $"{GetType()}\n{_eventTitle}\n{_speaker}\n{_description}\nRegister Now. Limited Capacity of {_capacity}\n{_date},{_time}\n{EventAddress.GetAddressString()}";
    }



}
