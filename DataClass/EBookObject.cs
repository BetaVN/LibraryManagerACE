using System;

namespace Assignment_ACE.DataClass
{
    internal class EBookObject
    {
        private string EBookName { get; set; }
        private string Author { get; set; }
        private string PublishPlatform { get; set; }
        private DateTime PublishDate { get; set; }

        public EBookObject(string name, string author, string publisher, DateTime publishdate)
        {
            this.EBookName = name;
            this.Author = author;
            this.PublishPlatform = publisher;
            this.PublishDate = publishdate;
        }

        public string getEBookName()
        {
            return this.EBookName;
        }

        public string getEBookAuthor()
        {
            return this.Author;
        }

        public string getEBookPublisher()
        {
            return this.PublishPlatform;
        }

        public DateTime getEBookDate()
        {
            return this.PublishDate;
        }

        public void changeEBookName(string name)
        {
            this.EBookName = name;
            return;
        }

        public void changeEBookAuthor(string author)
        {
            this.Author = author;
            return;
        }

        public void changeEBookPublisher(string publisher)
        {
            this.PublishPlatform = publisher;
            return;
        }

        public void changeEBookPublishDate(DateTime date)
        {
            this.PublishDate = date;
            return;
        }
    }
}