using System;

namespace YouTubeVideos

{

    // Stores information about a single comment on a video

    public class Comment

    {

        public string Name { get; set; }

        public string Text { get; set; }

        public Comment(string name, string text)

        {

            Name = name;

            Text = text;

        }

    }

}