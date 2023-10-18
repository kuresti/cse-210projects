using System;

public class Reference
{
    //Private attributes of the Reference class
    private string _book;
    private int _chapter;
    private int _verse1;
    private int _lastVerse;

    //Constructors for the Reference class
    //The first constructor is the default for the basic requirement
    public Reference()
    {
        _book = "2 Nephi";
        _chapter = 1;
        _verse1 = 15;
        Console.WriteLine($"{_book} {_chapter}:{_verse1}: ");
    }

    //Constructor that is patterned like the default
    //but it can set different values to the attributes
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = startVerse;
        Console.WriteLine($"{book} {chapter}:{startVerse}:");
    }

    //Constructor that can set values for _book, _chapter, 
    //_verse1 and _lastVerse
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse1 = startVerse;
        _lastVerse = endVerse;
        Console.WriteLine($"{book} {chapter}:{startVerse}-{endVerse}:");
    }


}