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


}