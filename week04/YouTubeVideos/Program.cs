using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold all videos
            List<Video> videos = new List<Video>();

            // Create first video and add comments
            Video video1 = new Video("How to Bake Bread", "Chef Anna", 420);
            video1.AddComment(new Comment("Mia", "This was so easy to follow!"));
            video1.AddComment(new Comment("James", "My bread turned out great."));
            video1.AddComment(new Comment("Lena", "Thanks for sharing this recipe."));
            videos.Add(video1);

            // Create second video and add comments
            Video video2 = new Video("Intro to Guitar", "MusicMaster", 615);
            video2.AddComment(new Comment("Chris", "Very helpful for beginners."));
            video2.AddComment(new Comment("Ava", "I finally learned my first chord!"));
            video2.AddComment(new Comment("Noah", "Great explanation."));
            videos.Add(video2);

            // Create third video and add comments
            Video video3 = new Video("Python Basics", "CodeLab", 780);
            video3.AddComment(new Comment("Emma", "Perfect for starting out."));
            video3.AddComment(new Comment("Oliver", "Clear and concise."));
            video3.AddComment(new Comment("Sophia", "I understand variables now."));
            video3.AddComment(new Comment("Liam", "Awesome tutorial."));
            videos.Add(video3);

            // Create fourth video and add comments
            Video video4 = new Video("Morning Workout Routine", "FitLife", 360);
            video4.AddComment(new Comment("Ella", "This got my day started right!"));
            video4.AddComment(new Comment("Henry", "Good pace and great energy."));
            video4.AddComment(new Comment("Grace", "I will try this tomorrow."));
            videos.Add(video4);

            // Display information for each video
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");

                // Display each comment for the current video
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  {comment.Name}: {comment.Text}");
                }

                Console.WriteLine();
            }
        }
    }
}