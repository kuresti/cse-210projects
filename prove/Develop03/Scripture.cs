using System;

public class Scripture
{
    //Attributes of the Scripture class
    //The _text attribute holds the text of the scripture passage
    private string _text;

    //This attribute is type Reference from the Reference class            
    private Reference _reference;

    //This attribute holds a list of the words that make
    //up the scripture passage
    private List<Word> _words = new List<Word>();

    //Creating an instance of the Random class to
    //use when picking random words to hide
    Random random = new Random();

    //Constructor of the Scripture class that takes two
    //parameters, string text, and Reference reference
    public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;

        //Using the split method to split the text into
        //individual words. This is split by a space
        //because no deliminator was specified.
        string[] words = text.Split();

        //Use a foreach loop to iterate through each word
        //in the words array. In the loop create a wordObj
        //type Word and add each wordObj to the previously
        //created word list in the attributes above.
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
        }
    }

        //The follow code was to test to see if the Scripture
        //constructor was populating the _words list
       /* foreach (Word wordObj in _words)
        {
        Console.WriteLine(wordObj.GetWord());
        }*/

        //This method uses a while loop to use a randomizer
        //to pick 3 random words in the text to hide. It also
        //uses an if statement to check if the randomly picked
        //word is already hidden. If it is not hidden the next
        //part of the code will hide the word by using the 
        //SetIsHidden method to set the _isHidden attribute to true.
        //If the word is already hidden the loop repeats choosing
        //a random word until it finds an unhidden word.
    public void HideWords()
    {
        //Initialized the index variable
         int index;

        int count = 0;       

        // Check if a single word is hidden. Hide if true.
        // Otherwise, get another word to hide. 
        // WATCH OUT incase 2 words or last.

        while (count != 3)
        {
            index = random.Next(_words.Count);
            if (WordsHidden() == true)
            {
                count = 3;
            }
            else{
                //  check if that one word is hidden then hide word(setHidden(true)).
                if (_words[index].GetIsHidden() == false)
                {
                    // Hide a word using the index we have.
                    _words[index].SetIsHidden(true);
                    
                    count += 1;
                }
            }
        }
        
    }

        //This method checks to see if all the words
        //in the scripture text are hidden. It does this
        //by using a foreach loop and calling the GetIsHidden
        //method to check if each word is hidden. The method
        //only returns true if all words in the text are
        //hidden.
        public bool WordsHidden()
        {
            foreach (Word word in _words)
            {
                if(!word.GetIsHidden())
                    return false;
            }
            return true;
        }

        //Note for self tomorrow: how do I test this method to ensure it is working?
        //This method calls the GetReferenceString to display
        //the book, chapter, verse(s) of the scripture text
    public void DisplayScripture()
    {
        //This calls the GetReferenceString from the Reference class
        //to display it before the scripture text.
        Console.Write(_reference.GetReferenceString());
        
        //The foreach loop iterates through the _words list
        //and displays it with a Console.Write to put them
        //in a string deliminated with a space.
        foreach (Word word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
        }
    }
    
    

