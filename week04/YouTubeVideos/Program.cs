using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // video 1
        List<Comment> vid1Com = new List<Comment>();
        Comment com1_1 = new Comment("StacyDude21", "This recipe is sick, it's my new favorite!  I'm going to make this every night!");
        Comment com1_2 = new Comment("BlazeMonger", "The bread choice is lacking, I would go with a traditional white myself");
        Comment com1_3 = new Comment("'WhichWitch", "Ignore the last comment, this recipe is great as is!");
        vid1Com.AddRange(com1_1, com1_2, com1_3);
        Video vid1 = new Video("Top Tier Grilled Cheese", "Mr. Mouse", 256, vid1Com);
        vid1.displayVideo();
        List<Comment> vid2Com = new List<Comment>();
        Comment com2_1 = new Comment("LadyFin", "This kid is reckless, where are his parents!");
        Comment com2_2 = new Comment("NotGuyFieri", "Sick tricks dude, never slow down!");
        Comment com2_3 = new Comment("FlipTrickSteve", "I could do better, but not bad for an amateur.");
        vid2Com.AddRange(com2_1, com2_2, com2_3);
        Video vid2 = new Video("Kick Flip Half Pipe Run", "Lil' Hawk", 196, vid2Com);
        vid2.displayVideo();
        List<Comment> vid3Com = new List<Comment>();
        Comment com3_1 = new Comment("RockinRoll", "Wish we had snow like that!");
        Comment com3_2 = new Comment("SnowConeLuvr", "I bet that powder tastes so good...");
        Comment com3_3 = new Comment("RealIgloo", "Not bad, don't forget to use water to freeze the structure.");
        vid3Com.AddRange(com3_1, com3_2, com3_3);
        Video vid3 = new Video("Snowplow Parking Lot Igloos", "FreezePhrame", 540, vid3Com);
        vid3.displayVideo();
        List<Comment> vid4Com = new List<Comment>();
        Comment com4_1 = new Comment("MaryK", "Classic scene from a classic movie.");
        Comment com4_2 = new Comment("BrakeDancr42", "It's like I'm watching the movie again!");
        Comment com4_3 = new Comment("BroHam", "Love this part, I can watch it all day");
        vid4Com.AddRange(com4_1, com4_2, com4_3);
        Video vid4 = new Video("White Chicks Dance Off Remake", "Mr Mister", 256, vid4Com);
        vid4.displayVideo();
        // video 2
        // video 3
        // video 4
    }
}