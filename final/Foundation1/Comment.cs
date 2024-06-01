using System;
using System.Collections.Generic;

namespace YouTubeTrackerProject
{

  public class Comment
    {
        public string _commentText;
       

        List <Comment>  Comments = new List<Comment>();
         public List<Video> _videos  = new List<Video>();
    

public void AddCommentToVideo(List<Video> videos)
        {
            if (videos.Count == 0)
            {
                Console.WriteLine("No videos available. Please add a video first.");
                return;
            }

           DisplayAllVideos(videos, false);
                
            Console.Write("Enter the video number to add a comment to: ");
            if (int.TryParse(Console.ReadLine(), out int videoIndex) && videoIndex > 0 && videoIndex <= videos.Count)
            {
                
                Console.Write("Enter your Name: ");
                string commentator = Console.ReadLine();

                
                Console.Write("Enter your comment: ");
                string commentText = Console.ReadLine();

                

                videos[videoIndex - 1]._Comments.Add(new Comment { _commentText = commentator });

                videos[videoIndex - 1]._Comments.Add(new Comment { _commentText = commentText });
                Console.WriteLine("Comment added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid video number, please try again.");
            }
        }
        public  void DisplayAllVideos(List<Video> videos, bool withComments = true)
        {
            if (videos.Count == 0)
            {
                Console.WriteLine("No videos available.");
                return;
            }

            for (int i = 0; i < videos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {videos[i]._titleOfVideo} by {videos[i]._authorName} ({videos[i]._LengthOfVideo} seconds)");

                if (withComments && videos[i]._Comments.Count > 0)
                {
                    Console.WriteLine("   Comments:\n Your name and Comment are:");
                    foreach (var comment in videos[i]._Comments)
                    {
                        Console.WriteLine($"   -{comment._commentText}");
                       // Console.WriteLine($"  Your comment - {comment._commentText}");
                        Console.WriteLine();
                    }
                }
            }
        }
}
}