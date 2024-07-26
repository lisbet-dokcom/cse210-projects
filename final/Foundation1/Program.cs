using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Cook Pasta", "Chef John", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Thanks for the tips!"));

        Video video2 = new Video("Learn Guitar in 10 Minutes", "Guitar Guru", 600);
        video2.AddComment(new Comment("Charlie", "Very helpful, thanks!"));
        video2.AddComment(new Comment("Dave", "Awesome tutorial!"));
        video2.AddComment(new Comment("Eve", "Loved it!"));

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}