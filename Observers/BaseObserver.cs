using System;

namespace Assignment_ACE.Observers
{
    public interface BaseObserver
    {
        string getName();

        string getAuthor();

        string getSource();

        DateTime getReleaseDate();

        bool isDigital();

        int getStock();

        string getType();

        void changeName(string name);

        void changeAuthor(string author);

        void changeSource(string source);

        void changeReleaseDate(DateTime date);

        void changeStock(int count);

        void changeType(string type);
    }
}