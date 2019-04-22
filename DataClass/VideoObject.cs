using System;

namespace Assignment_ACE.DataClass
{
    internal class VideoObject
    {
        private string VideoName { get; set; }
        private string VideoType { get; set; }
        private string Author { get; set; }
        private DateTime PublishDate { get; set; }
        private string Source { get; set; }
        private bool isFile { get; set; }
        private int ItemCount { get; set; }

        public VideoObject(string name, string type, string author, DateTime publishdate, string source, bool isFile, int count = 0)
        {
            this.VideoName = name;
            this.VideoType = type;
            this.Author = author;
            this.PublishDate = publishdate;
            this.Source = source;
            this.isFile = isFile;
            this.ItemCount = count;
        }

        public string getVideoName()
        {
            return this.VideoName;
        }

        public string getVideoType()
        {
            return this.VideoType;
        }

        public string getVideoAuthor()
        {
            return this.Author;
        }

        public string getVideoSource()
        {
            return this.Source;
        }

        public DateTime getVideoDate()
        {
            return this.PublishDate;
        }

        public bool getVideoFile()
        {
            return this.isFile;
        }

        public int getRemainingVideo()
        {
            return this.ItemCount;
        }

        public void changeVideoName(string name)
        {
            this.VideoName = name;
            return;
        }

        public void changeVideoType(string type)
        {
            this.VideoType = type;
            return;
        }

        public void changeVideoAuthor(string author)
        {
            this.Author = author;
            return;
        }

        public void changeVideoSource(string source)
        {
            this.Source = source;
            return;
        }

        public void changeVideoPublishDate(DateTime date)
        {
            this.PublishDate = date;
            return;
        }

        public void changeRemainingVideo(int stock)
        {
            this.ItemCount = stock;
            return;
        }
    }
}