using System;

public class MathAssignment : Assignment
{
    //Attributes of MathAssignment 
    private string _textBookSection;
    private string _problems;

    //Constructor of MathAssignment that accepts all 4 variables
    //and calls the base class contructor to set the base class
    //attributes that way.
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic) 
    {
        _textBookSection = textBookSection;
        _problems = problems;
    
    }

    //Method that gets the homewok list
    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }

}