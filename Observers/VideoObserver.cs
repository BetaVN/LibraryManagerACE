using Assignment_ACE.DataClass;
using System;

namespace Assignment_ACE.Observers
{
    internal class VideoObserver : BaseObserver
    {
        private VideoObject videoContext { get; set; }

        public VideoObserver(VideoObject subject)
        {
            this.videoContext = subject;
        }

        string BaseObserver.getName()
        {
            string name = videoContext.getVideoName();
            return name;
        }

        string BaseObserver.getAuthor()
        {
            string author = videoContext.getVideoAuthor();
            return author;
        }

        string BaseObserver.getSource()
        {
            string source = videoContext.getVideoSource();
            return source;
        }

        DateTime BaseObserver.getReleaseDate()
        {
            DateTime date = videoContext.getVideoDate();
            return date;
        }

        bool BaseObserver.isDigital()
        {
            bool isDigital = videoContext.getVideoFile();
            return isDigital;
        }

        int BaseObserver.getStock()
        {
            int stock = videoContext.getRemainingVideo();
            return stock;
        }

        string BaseObserver.getType()
        {
            string type = videoContext.getVideoType();
            return type;
        }

        void BaseObserver.changeName(string name)
        {
            videoContext.changeVideoName(name);
            return;
        }

        void BaseObserver.changeAuthor(string author)
        {
            videoContext.changeVideoAuthor(author);
            return;
        }

        void BaseObserver.changeSource(string source)
        {
            videoContext.changeVideoSource(source);
            return;
        }

        void BaseObserver.changeReleaseDate(DateTime date)
        {
            videoContext.changeVideoPublishDate(date);
            return;
        }

        void BaseObserver.changeStock(int count)
        {
            videoContext.changeRemainingVideo(count);
            return;
        }

        void BaseObserver.changeType(string type)
        {
            videoContext.changeVideoType(type);
            return;
        }
    }
}