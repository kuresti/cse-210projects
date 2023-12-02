using System;

//LectureEvent class derived from 
//Event class
public class LectureEvent : Event
{
    //Attributes of LectureEvent
    private string _speaker;
    private string _capacity;

    //Constructors of LectureEvent
    //Constructor for Standard message
    public LectureEvent(string eventTitle, string description, string date, string time, Address address) : base(eventTitle, description, date, time, address)
    {}

    //Constructor for Full Details
    public LectureEvent(string eventTitle, string speaker, string description, string capacity, string date, string time, Address address) :base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //Constructor for ShortMessage
    public LectureEvent(string eventTitle, string date) : base(eventTitle, date)
    {}

    DisplayStandardMessage("Mind Mapping and Brain Expansion", "This lecture will change your view and expand your mind to the science of brain mapping.", "December 14, 2025", "7:00p.m.", "201 President's Cir, Anywhere, USA");

    DisplayFullDetails()


}
