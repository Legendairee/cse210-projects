using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video firstVideo = new Video("Exploring Olumo Rock and Ancient Abeokuta", "Naija Explorer", 1200);

        Comment comment1 = new Comment("Chidubem99", "Olumo Rock is truly iconic! I remember climbing those stairs back in 2019.");
        Comment comment2 = new Comment("Tunde", "Egba land has so much rich history. Great coverage bro!");
        Comment comment3 = new Comment("Okon-vibes", "Nice video! Please visit Obudu Cattle Ranch in Cross River next.");

        firstVideo.AddComment(comment1);
        firstVideo.AddComment(comment2);
        firstVideo.AddComment(comment3);

        videos.Add(firstVideo);


        Video secondVideo = new Video("How to Prepare Authentic Party Jollof Rice", "Chef Kemi's Kitchen", 845);

        Comment comment4 = new Comment("Emeka ", "The firewood smokiness is the real secret! Looks so delicious.");
        Comment comment5 = new Comment("Foodie", "Which brand of curry powder did you use at minute 4:15?");
        Comment comment6 = new Comment("Ayomide", "Abeg send my own portion down to Lekki Phase 1!");

        secondVideo.AddComment(comment4);
        secondVideo.AddComment(comment5);
        secondVideo.AddComment(comment6);

        videos.Add(secondVideo);

    
        Video thirdVideo = new Video("Inside Yaba: The Silicon Valley of Lagos", "TechNaija Digest", 1530);

        Comment comment7 = new Comment("CodeWithSola", "Yaba tech ecosystem has come a really long way. Super proud!");
        Comment comment8 = new Comment("Fatima@Kaduna", "Awesome insights! Hope startups in Northern Nigeria get profiled too.");
        Comment comment9 = new Comment("Dev_Cracker", "Bro, the internet connectivity issues you mentioned are so relatable.");

        thirdVideo.AddComment(comment7);
        thirdVideo.AddComment(comment8);
        thirdVideo.AddComment(comment9);

        videos.Add(thirdVideo);


        Video fourthVideo = new Video("Evolution of Afrobeats: From Fela Kuti to Burna Boy", "AfroSound Culture", 960);

        Comment comment10 = new Comment("Dayo Vibes", "Afrobeats to the world! The global recognition is well deserved.");
        Comment comment11 = new Comment("Blessing_PH", "Fela Kuti's musical foundation can never be erased. Pure legend!");
        Comment comment12 = new Comment("Olushola Bade", "Super solid breakdown. The editing quality is top notch as always!");

        fourthVideo.AddComment(comment10);
        fourthVideo.AddComment(comment11);
        fourthVideo.AddComment(comment12);

        videos.Add(fourthVideo);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}