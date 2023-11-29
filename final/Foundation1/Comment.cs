using System;


//The comment class defines a comment
public class Comment
{
    //Attributes of Comment class
    public string _name;
    public string _text;

    //Comment class constructor
    public Comment()
    {
        _name = "";
        _text = "";
    }

    //Display Comment method
    public void DisplayComments()
    {
        Console.WriteLine($"Name of Commentor: {_name}");
        Console.WriteLine($"Comment text: {_text}");
    }

}