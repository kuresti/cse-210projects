using System;

public class Reference
{
   //Private attributes of the Reference class
   private string _book;
   private string _chapter;
   private string _startVerse;
   private string _lastVerse;

   //Reference constructor that give the reference of one verse
   public Reference(string book, string chapter, string beginVerse)
   {
        _book = book;
        _chapter = chapter;
        _startVerse = beginVerse;
        Console.WriteLine($"{book} {chapter}:{beginVerse}: ");
   }

   //Reference constructor that gives the reference for multiple verses
   public Reference(string book, string chapter, string beginVerse, string endVerse)
   {
     _book = book;
     _chapter = chapter;
     _startVerse = beginVerse;
     _lastVerse = endVerse;
     Console.WriteLine($"{book} {chapter}:{beginVerse}-{endVerse}: ");
   }

   //Method to check whether the passage is one verse or multiple verses
   public string GetReferenceString()
   {
    if(_lastVerse == null)
        return $"{_book} {_chapter}:{_startVerse}: ";
    else
        return $"{_book} {_chapter}:{_startVerse}-{_lastVerse}: ";
   }

    


}