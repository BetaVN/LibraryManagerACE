using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_ACE.DataClass;

namespace Assignment_ACE.Observers
{
    class BookObserver : BaseObserver
    {
        private BookObject bookContext { get; set; }

        public BookObserver(BookObject subject)
        {
            this.bookContext = subject;
        }

        string BaseObserver.getName()
        {
            string name = bookContext.getBookName();
            return name;
        }

        string BaseObserver.getAuthor()
        {
            string author = bookContext.getBookAuthor();
            return author;
        }

        string BaseObserver.getSource()
        {
            string source = bookContext.getBookPublisher();
            return source;
        }

        DateTime BaseObserver.getReleaseDate()
        {
            DateTime date = bookContext.getBookDate();
            return date;
        }

        bool BaseObserver.isDigital()
        {
            return false;
        }

        int BaseObserver.getStock()
        {
            int stock = bookContext.getRemainingBook();
            return stock;
        }

        string BaseObserver.getType()
        {
            return "None";
        }

        void BaseObserver.changeName(string name)
        {
            bookContext.changeBookName(name);
            return;
        }

        void BaseObserver.changeAuthor(string author)
        {
            bookContext.changeBookAuthor(author);
            return;
        }

        void BaseObserver.changeSource(string source)
        {
            bookContext.changeBookPublisher(source);
            return;
        }

        void BaseObserver.changeReleaseDate(DateTime date)
        {
            bookContext.changeBookPublishDate(date);
            return;
        }

        void BaseObserver.changeStock(int count)
        {
            bookContext.changeRemainingBook(count);
            return;
        }
        void BaseObserver.changeType(string type)
        {
            return;
        }
    }
}
