using System;

//Video class that stores details of the videos
public class Video
{
    //Attributes of the videos
    public string _title;
    public string _author;
    public int _videoLength;
    public List<Comment> _comments;   
    public List<Video> _videos;
    public int _numComments;

    
    //Constructor of Video class
    public Video()
    {
        //Instantiating attributes of the Video class
        _title = "";
        _author = "";
        _videoLength = 0;
        _numComments = 0;        
        _videos = new List<Video>();
        _comments = new List<Comment>(); 
    }

    //Methods of Video
     public void NumberOfComments()
    {
        _numComments = _comments.Count();
        Console.WriteLine($"There are {_numComments} comments for this video.");
    }

    

    //Display Video Details method
    public void DisplayVidDetails()
    {
        Console.WriteLine($"\nVideo title: {_title}");
        Console.WriteLine($"Author of Video: {_author}");
        Console.WriteLine($"Video Length: {_videoLength}");

        //Call NumberOfComments method
        NumberOfComments();

        //Loop to iterate through and print comment list
        foreach(Comment comment in _comments)
        {
            comment.DisplayComments();
        }
        
    }

    
    
}