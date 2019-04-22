using Assignment_ACE.DataClass;
using System;

namespace Assignment_ACE.Observers
{
    internal class EBookObserver : BaseObserver
    {
        private EBookObject ebookContext { get; set; }

        public EBookObserver(EBookObject subject)
        {
            this.ebookContext = subject;
        }

        string BaseObserver.getName()
        {
            string name = ebookContext.getEBookName();
            return name;
        }

        string BaseObserver.getAuthor()
        {
            string author = ebookContext.getEBookAuthor();
            return author;
        }

        string BaseObserver.getSource()
        {
            string source = ebookContext.getEBookPublisher();
            return source;
        }

        DateTime BaseObserver.getReleaseDate()
        {
            DateTime date = ebookContext.getEBookDate();
            return date;
        }

        bool BaseObserver.isDigital()
        {
            return true;
        }

        int BaseObserver.getStock()
        {
            return 0;
        }

        string BaseObserver.getType()
        {
            return "E-Book";
        }

        void BaseObserver.changeName(string name)
        {
            ebookContext.changeEBookName(name);
            return;
        }

        void BaseObserver.changeAuthor(string author)
        {
            ebookContext.changeEBookAuthor(author);
            return;
        }

        void BaseObserver.changeSource(string source)
        {
            ebookContext.changeEBookPublisher(source);
            return;
        }

        void BaseObserver.changeReleaseDate(DateTime date)
        {
            ebookContext.changeEBookPublishDate(date);
            return;
        }

        void BaseObserver.changeStock(int count)
        {
            return;
        }

        void BaseObserver.changeType(string type)
        {
            return;
        }
    }
}