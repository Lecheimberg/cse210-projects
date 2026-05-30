using System.Collections.Generic;

namespace YouTubeVideos
{
    // Represents a YouTube video and its comments
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }

        // List to store comments for this video :)
        private List<Comment> _comments;

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
            _comments = new List<Comment>();
        }

        // Adds a new comment to the video
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        // Returns the total number of comments
        public int GetCommentCount()
        {
            return _comments.Count;
        }

        // Returns the list of comments
        public List<Comment> GetComments()
        {
            return _comments;
        }
    }
}