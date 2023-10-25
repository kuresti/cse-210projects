using System;

public class WritingAssignment : Assignment
{
    //Attributest of the WritingAssignment Class
    protected string _title;


    //Constructor of the WritingAssignment Class
    public WritingAssignment(string studentName, string topic, string title) :base(studentName, topic)
    {
        _title = title;
    }

    //Method to return the Writing Assignment
    public string GetWritingAssignment()
    {
        return $"{_title} by {_studentName}";
    }

}