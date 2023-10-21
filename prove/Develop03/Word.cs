public class Word
{
    //Attributes for the Word class
    //This attribute will represent the Word object
    //created in the Scripture class
    private string _word;
    
    //This attribute will represent a boolean value
    private bool _isHidden = false;

    //This attribute represents the version of a word
    //when it is hidden

    private string _hiddenWord = "";

    //A constructor of the class Word that takes one 
    //argument which is the word object created by the Scripture
    //class constructor
    public Word(string word)
    {
        
        _word = word;

        //Setting _isHidden as false ensures that a created wordObj
        //will not be hidden by default.
        _isHidden = false;

        //Create a foreach loop to iterate through each letter in a 
        //word and if the word is hidden, replace the letter of 
        //the word with underscores.
        foreach (char letter in word)
        {
            _hiddenWord += "_";
        }
    }

    // HideWord()
    // _word = _hiddenWord

    //This method returns the _word attribute if the _isHidden attribute
    //is false. If it is true it returns the hidden form of the word.
    public string GetWord()
    {
        if(_isHidden)
        {
            return _hiddenWord;
        }
        else{
            return _word;
        }
    }
    
    //The following two methods control the status of a Word object
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool status)
    {
        _isHidden = status;
    }


    


}