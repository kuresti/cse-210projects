using System;

class Program
{
    static void Main(string[] args)
    {
        Reference test1 = new Reference();
        Reference verse = new Reference("2 Nephi", 1, 15);
        Reference verses = new Reference("2 Nephi", 2, 6, 7);

        
        Console.WriteLine(verse.GetReferenceOneVerse());
        Console.WriteLine(verses.GetReferenceMultiVerses());
    }
}