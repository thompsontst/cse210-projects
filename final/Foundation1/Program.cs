using System;
using System.Collections.Generic;

namespace YouTubeTrackerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nYouTube Tracker Menu:");
                Console.WriteLine("1. Add a new video");
                Console.WriteLine("2. Add a comment to a video");
                Console.WriteLine("3. Display all videos and comments");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Video video = new Video();
                        video.AddNewVideo(videos);
                        break;
                    case "2":
                        Comment comment = new Comment();
                        comment.AddCommentToVideo(videos);
                        break;
                    case "3":
                       Comment comments = new Comment();
                        comments.DisplayAllVideos(videos);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        

        

       
    }

  
 

  
}
