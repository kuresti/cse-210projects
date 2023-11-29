using System;

class Program
{
   
    static void Main(string[] args)
    {
      //List of videos
      List<Video> _videos = new List<Video>();

       //Creating Vid1 objects
       Video vid1 = new Video();
       vid1._title = "Sighting of Nessy";
       vid1._author = "Iona Seeum";
       vid1._videoLength = 90;       
       vid1._comments = new List<Comment>();

       //Creating comments for vid1 obj
       Comment vid1com1 = new Comment();
       vid1com1._name = "Ean NoSeeum";
       vid1com1._text = "It looks like a large log. It ain't no Monster.";

       
       Comment vid1com2 = new Comment();
       vid1com2._name = "Iona EyeSee";
       vid1com2._text = "Isn't she a beautiful creature! Great Video!";

       
       Comment vid1com3 = new Comment();
       vid1com3._name = "Henry Hearsay";
       vid1com3._text = "I heard she can take down a ship. Sure glad you are safe!";

       //Creating Vid2 objects
       Video vid2 = new Video();
       vid2._title = "Stars of Tomorrow";
       vid2._author = "Nova WhiteDwarf";
       vid2._videoLength = 120;
       vid2._comments = new List<Comment>();

       //Creating comments for vid2 obj
       Comment vid2com1 = new Comment();
       vid2com1._name = "Sirius Rigel";
       vid2com1._text = "Far Out! Great video!";

       Comment vid2com2 = new Comment();
       vid2com2._name = "Altair Taurus";
       vid2com2._text = "I vote for Bellatrix, she is the best!";

       Comment vid2com3 = new Comment();
       vid2com3._name = "Antares Scorpius";
       vid2com3._text = "Lyra is my all time favorite!";

       Comment vid2com4 = new Comment();
       vid2com4._name = "Arcturus Betelgeuse";
       vid2com4._text = "Polaris always shows the way!";

       //Creating vid3 obj
       Video vid3 = new Video();
       vid3._title = "Marvelous Media";
       vid3._author = "Stanlee Stark";
       vid3._videoLength = 180;
       vid3._comments = new List<Comment>();

       //Creating comments for vid3 obj
       Comment vid3com1 = new Comment();
       vid3com1._name = "Charlie Xavier";
       vid3com1._text = "The next time you feel like showing off...take me with you!";

       Comment vid3com2 = new Comment();
       vid3com2._name = "Janet Van Dyner";
       vid3com2._text = "I'm sorry, I think I can help you.";

       Comment vid3com3 = new Comment();
       vid3com3._name = "Logan Wolverine";
       vid3com3._text = "Your best is enough!";

       //Creating vid4 obj
       Video vid4 = new Video();
       vid4._title = "Mission to Dagobah";
       vid4._author = "Mace Jinn";
       vid4._videoLength = 240;
       vid4._comments = new List<Comment>();

       //Creating comments for vid 4 obj
       Comment vid4com1 = new Comment();
       vid4com1._name = "Stass Allie";
       vid4com1._text = "Reminds me of my jedi training days.";

       Comment vid4com2 = new Comment();
       vid4com2._name = "Eno Cordova";
       vid4com2._text = "May the force be with you.";
       
       Comment vid4com3 = new Comment();
       vid4com3._name = "Yoda Grogo";
       vid4com3._text = "My home it is.";

       Comment vid4com4 = new Comment();
       vid4com4._name = "Kit Fisto";
       vid4com4._text = "Great training video!";
       

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