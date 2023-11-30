using System;

class Program
{
   
    static void Main(string[] args)
    {
      //List of videos
      List<Video> _videos = new List<Video>();

       //Creating Vid1 objects
       Video vid1 = new Video("Sighting of Nessy", "Iona Seeum",90 );
       vid1._comments = new List<Comment>();

       //Creating comments for vid1 obj
       Comment vid1com1 = new Comment("Ean NoSeeum","It looks like a large log. It ain't no Monster.");
           
       Comment vid1com2 = new Comment("Iona EyeSee", "Isn't she a beautiful creature! Great Video!");
           
       Comment vid1com3 = new Comment("Henry Hearsay", "I heard she can take down a ship. Sure glad you are safe!");
    

        //Creating Vid2 objects
        Video vid2 = new Video("Stars of Tomorrow", "Nova WhiteDwarf", 120);
        vid2._comments = new List<Comment>();

        //Creating comments for vid2 obj
        Comment vid2com1 = new Comment("Sirius Rigel", "Far Out! Great video!");
    
        Comment vid2com2 = new Comment("Altair Taurus", "I vote for Bellatrix, she is the best!");
    
        Comment vid2com3 = new Comment("Antares Scorpius", "Lyra is my all time favorite!");
    
        Comment vid2com4 = new Comment("Arcturus Betelgeuse", "Polaris always shows the way!");
    

        //Creating vid3 obj
        Video vid3 = new Video("Marvelous Media", "Stanlee Stark", 180);
        vid3._comments = new List<Comment>();

        //Creating comments for vid3 obj
        Comment vid3com1 = new Comment("Charlie Xavier", "The next time you feel like showing off...take me with you!");
    
        Comment vid3com2 = new Comment("Janet Van Dyner", "I'm sorry, I think I can help you.");
    
        Comment vid3com3 = new Comment("Logan Wolverine", "Your best is enough!");
    

        //Creating vid4 obj
        Video vid4 = new Video("Mission to Dagobah", "Mace Jinn", 240);
        vid4._comments = new List<Comment>();

        //Creating comments for vid 4 obj
        Comment vid4com1 = new Comment("Stass Allie", "Reminds me of my jedi training days.");    

        Comment vid4com2 = new Comment("Eno Cordova", "May the force be with you.");    
       
        Comment vid4com3 = new Comment("Yoda Grogo", "My home it is.");    

        Comment vid4com4 = new Comment("Kit Fisto", "Great training video!");
    

       //Adding comments to vid1 _comments list
       vid1._comments.Add(vid1com1);
       vid1._comments.Add(vid1com2);
       vid1._comments.Add(vid1com3);

       //Adding comments to vid2 _comments list
       vid2._comments.Add(vid2com1);
       vid2._comments.Add(vid2com2);
       vid2._comments.Add(vid2com3);
       vid2._comments.Add(vid2com4);

       //Adding comments to vid3 _comments list
       vid3._comments.Add(vid3com1);
       vid3._comments.Add(vid3com2);
       vid3._comments.Add(vid3com3);
       
       //Adding comments to vid4 _comments list
       vid4._comments.Add(vid4com1);
       vid4._comments.Add(vid4com2);
       vid4._comments.Add(vid4com3);
       vid4._comments.Add(vid4com4);

       //Adding videos to _videos list
        _videos.Add(vid1);
        _videos.Add(vid2);
        _videos.Add(vid3);
        _videos.Add(vid4);

       //Iterate through videos in list and display details
       static void  DisplayVideoList(List<Video> _videos)
       {
        foreach(Video video in _videos)
        {
            video.DisplayVidDetails();
        }
       }

       //Call Display Video details  
       DisplayVideoList(_videos);   
       
        
    }
}