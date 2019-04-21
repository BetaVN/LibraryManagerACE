using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ACE.DataClass
{
    class AudioObject
    {
        private string AudioName { get; set; }
        private string AudioType { get; set; }
        private string Author { get; set; }
        private DateTime PublishDate { get; set; }
        private string Source { get; set; }
        private bool isFile { get; set; }
        private int ItemCount { get; set; }

        public AudioObject(string name, string type, string author, DateTime publishdate, string source, bool isFile, int count = 0)
        {
            this.AudioName = name;
            this.AudioType = type;
            this.Author = author;
            this.PublishDate = publishdate;
            this.Source = source;
            this.isFile = isFile;
            this.ItemCount = count;
        }

        public string getAudioName()
        {
            return this.AudioName;
        }

        public string getAudioType()
        {
            return this.AudioType;
        }

        public string getAudioAuthor()
        {
            return this.Author;
        }

        public string getAudioSource()
        {
            return this.Source;
        }

        public DateTime getAudioDate()
        {
            return this.PublishDate;
        }

        public bool getAudioFile()
        {
            return this.isFile;
        }

        public int getRemainingAudio()
        {
            return this.ItemCount;
        }

        public void changeAudioName(string name)
        {
            this.AudioName = name;
            return;
        }

        public void changeAudioType(string type)
        {
            this.AudioType = type;
            return;
        }

        public void changeAudioAuthor(string author)
        {
            this.Author = author;
            return;
        }

        public void changeAudioSource(string source)
        {
            this.Source = source;
            return;
        }

        public void changeAudioPublishDate(DateTime date)
        {
            this.PublishDate = date;
            return;
        }

        public void changeRemainingAudio(int stock)
        {
            this.ItemCount = stock;
            return;
        }
    }
}
