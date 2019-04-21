using Assignment_ACE.Visitor;
using System;

namespace Assignment_ACE.DataClass
{
    public struct MaterialInfo
    {
        public string name;
        public string author;
        public string publisher;
        public DateTime publishDate;
        public int itemcount;
        public string type;
        public bool isFile;
        public string classname;

        public MaterialInfo(string name, string author, string publisher, DateTime date, int count, string type, bool isFile, string classname)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.publishDate = date;
            this.itemcount = count;
            this.type = type;
            this.isFile = isFile;
            this.classname = classname;
        }

        public void update(string name, string author, string publisher, DateTime date, int count, string type)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.publishDate = date;
            this.itemcount = count;
            this.type = type;
        }

        public void accept(SummaryVisitor collector)
        {
            if (classname.Contains(".Book"))
            {
                collector.bookCount++;
                collector.bookStock += this.itemcount;
            }
            else if (classname.Contains(".EBook"))
            {
                collector.eBookCount++;
            }
            else if (classname.Contains(".Video"))
            {
                if (this.isFile)
                {
                    collector.videoDCount++;
                }
                else
                {
                    collector.videoPCount++;
                    collector.videoPStock += this.itemcount;
                }
            }
            else if (classname.Contains(".Audio"))
            {
                if (this.isFile)
                {
                    collector.audioDCount++;
                }
                else
                {
                    collector.audioPCount++;
                    collector.audioPStock += this.itemcount;
                }
            }
            return;
        }
    }
}
