using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_ACE.DataClass
{
    class BookObject
    {
        private string BookName { get; set; }
        private string Author { get; set; }
        private string Publisher { get; set; }
        private DateTime PublishDate { get; set; }
        private int ItemCount { get; set; }

        public BookObject(string name, string author, string publisher, DateTime publishdate, int itemcount)
        {
            this.BookName = name;
            this.Author = author;
            this.Publisher = publisher;
            this.PublishDate = publishdate;
            this.ItemCount = itemcount;
        }

        public string getBookName()
        {
            return this.BookName;
        }

        public string getBookAuthor()
        {
            return this.Author;
        }

        public string getBookPublisher()
        {
            return this.Publisher;
        }

        public DateTime getBookDate()
        {
            return this.PublishDate;
        }

        public int getRemainingBook()
        {
            return this.ItemCount;
        }

        public void changeBookName(string name)
        {
            this.BookName = name;
            return;
        }

        public void changeBookAuthor(string author)
        {
            this.Author = author;
            return;
        }

        public void changeBookPublisher(string publisher)
        {
            this.BookName = publisher;
            return;
        }

        public void changeBookPublishDate(DateTime date)
        {
            this.PublishDate = date;
            return;
        }

        public void changeRemainingBook(int stock)
        {
            this.ItemCount = stock;
            return;
        }

    }
}
