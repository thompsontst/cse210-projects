using System;
using System.Collections.Generic;

namespace YouTubeTrackerProject
{
    
        public class Video
        {
               
        public string _titleOfVideo;
        public string _authorName;
        public int _LengthOfVideo;
        
        public List<Comment> _Comments  = new List<Comment>();

    
        public void AddNewVideo(List<Video> videos)
        {
            Console.Write("Enter the name of the Youtube Video: ");
            string nameOfVideo = Console.ReadLine();
            Console.Write("Enter the author of the  Youtube Video: ");
            string authorOfVideo = Console.ReadLine();

            Console.Write("Enter the Video length (in seconds): ");


            if (int.TryParse(Console.ReadLine(), out int length))
            {
                videos.Add(new Video { _titleOfVideo = nameOfVideo, _authorName = authorOfVideo, _LengthOfVideo = length });
                Console.WriteLine("Video added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid length. Please enter the length in seconds.");
            }
        }
         
        
        }

    
    }