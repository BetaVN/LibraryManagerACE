using Assignment_ACE.DataClass;
using System;

namespace Assignment_ACE.Observers
{
    internal class AudioObserver : BaseObserver
    {
        private AudioObject audioContext { get; set; }

        public AudioObserver(AudioObject subject)
        {
            this.audioContext = subject;
        }

        string BaseObserver.getName()
        {
            string name = audioContext.getAudioName();
            return name;
        }

        string BaseObserver.getAuthor()
        {
            string author = audioContext.getAudioAuthor();
            return author;
        }

        string BaseObserver.getSource()
        {
            string source = audioContext.getAudioSource();
            return source;
        }

        DateTime BaseObserver.getReleaseDate()
        {
            DateTime date = audioContext.getAudioDate();
            return date;
        }

        bool BaseObserver.isDigital()
        {
            bool isDigital = audioContext.getAudioFile();
            return isDigital;
        }

        int BaseObserver.getStock()
        {
            int stock = audioContext.getRemainingAudio();
            return stock;
        }

        string BaseObserver.getType()
        {
            string type = audioContext.getAudioType();
            return type;
        }

        void BaseObserver.changeName(string name)
        {
            audioContext.changeAudioName(name);
            return;
        }

        void BaseObserver.changeAuthor(string author)
        {
            audioContext.changeAudioAuthor(author);
            return;
        }

        void BaseObserver.changeSource(string source)
        {
            audioContext.changeAudioSource(source);
            return;
        }

        void BaseObserver.changeReleaseDate(DateTime date)
        {
            audioContext.changeAudioPublishDate(date);
            return;
        }

        void BaseObserver.changeStock(int count)
        {
            audioContext.changeRemainingAudio(count);
            return;
        }

        void BaseObserver.changeType(string type)
        {
            audioContext.changeAudioType(type);
            return;
        }
    }
}