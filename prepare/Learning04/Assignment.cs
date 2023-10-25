using System;

public class Assignment
{
    //Attributes of the base class Assignment
    protected string _studentName;
    protected string _topic;

//Constructor that takes two parameters studentName and topic
public Assignment(string studentName, string topic)
{
    _studentName = studentName;
    _topic = topic;
}

//Method that will return the student's name and the topic.
public string GetSummary()
{
    return $"{_studentName}-{_topic}";
}

}