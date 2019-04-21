using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Assignment_ACE.Observers;
using Assignment_ACE.DataClass;
using System.Globalization;
using System.Windows.Forms;

namespace Assignment_ACE.Manager
{
    class LibraryManager
    {
        private List<BaseObserver> materialList = new List<BaseObserver>();

        public void addMaterial(BaseObserver newMaterial)
        {
            materialList.Add(newMaterial);
        }

        public LibraryManager()
        {
            initLibrary();
        }

        public void removeMaterial(string name, string type)
        {
            foreach (BaseObserver material in materialList)
            {
                if (material.getName() == name && material.getType() == type)
                {    
                    materialList.Remove(material);
                    return;
                }
            }
            return;
        }

        public void notifyUpdate(MaterialInfo updatedInfo)
        {
            foreach (BaseObserver material in materialList)
            {
                if (material.getName() == updatedInfo.name && material.getType() == updatedInfo.type)
                {
                    material.changeName(updatedInfo.name);
                    material.changeAuthor(updatedInfo.author);
                    material.changeSource(updatedInfo.publisher);
                    material.changeReleaseDate(updatedInfo.publishDate);
                    material.changeStock(updatedInfo.itemcount);
                    material.changeType(updatedInfo.type);
                    return;
                }
            }
            return;
        }

        public List<MaterialInfo> readList()
        {
            List<MaterialInfo> dataList = new List<MaterialInfo>();
            foreach (BaseObserver material in this.materialList)
            {
                string name = material.getName();
                string author = material.getAuthor();
                string publisher = material.getSource();
                DateTime date = material.getReleaseDate();
                int count = material.getStock();
                string type = material.getType();
                bool isFile = material.isDigital();
                MaterialInfo getter = new MaterialInfo(name, author, publisher, date, count, type, isFile, material.GetType().ToString());
                dataList.Add(getter);
            }
            return dataList;
        }

        private void initLibrary()
        {
            string path = @"Database\MaterialItems.txt";
            string[] materialData;
            materialData = File.ReadAllLines(path);

            foreach (string data in materialData)
            {
                string[] datas = data.Split('|');
                string name = datas[1];
                string author = datas[2];
                string publisher = datas[3];
                DateTime publishDate = DateTime.ParseExact(datas[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int stock = 0;
                bool isFile = false;
                if (datas[5] == "F")
                {
                    isFile = true;
                    stock = 0;
                }
                else
                {
                    stock = Convert.ToInt16(datas[5]);
                }
                string type = datas[6];
                switch (datas[0])
                {
                    case "Book":
                        BookObject newBook = new BookObject(name, author, publisher, publishDate, stock);
                        BookObserver newBookObserver = new BookObserver(newBook);
                        this.materialList.Add(newBookObserver);
                        break;
                    case "EBook":
                        EBookObject newEBook = new EBookObject(name, author, publisher, publishDate);
                        EBookObserver newEBookObserver = new EBookObserver(newEBook);
                        this.materialList.Add(newEBookObserver);
                        break;
                    case "Video":
                        VideoObject newVideo = new VideoObject(name, type, author, publishDate, publisher, isFile, stock);
                        VideoObserver newVideoObserver = new VideoObserver(newVideo);
                        this.materialList.Add(newVideoObserver);
                        break;
                    case "Audio":
                        AudioObject newAudio = new AudioObject(name, type, author, publishDate, publisher, isFile, stock);
                        AudioObserver newAudioObserver = new AudioObserver(newAudio);
                        this.materialList.Add(newAudioObserver);
                        break;
                    default:
                        break;
                }
            }
            return;
        }

        public void exitManager()
        {
            string path = @"Database\MaterialItems.txt";
            List<string> materialData = new List<string>();

            foreach (BaseObserver material in this.materialList)
            {
                string classname = "";
                switch (material.GetType().ToString())
                {
                    case "Assignment_ACE.Observers.BookObserver":
                        classname = "Book";
                        break;
                    case "Assignment_ACE.Observers.EBookObserver":
                        classname = "EBook";
                        break;
                    case "Assignment_ACE.Observers.VideoObserver":
                        classname = "Video";
                        break;
                    case "Assignment_ACE.Observers.AudioObserver":
                        classname = "Audio";
                        break;
                }
                string name = material.getName();
                string author = material.getAuthor();
                string publisher = material.getSource();
                string publishDate = material.getReleaseDate().ToString("dd/mm/yyyy");
                string stock;
                if (material.isDigital())
                {
                    stock = "F";
                }
                else
                {
                    stock = material.getStock().ToString();
                }
                string type = material.getType();
                materialData.Append(classname + "|" + name + "|" + author + "|" + publisher + "|" + publishDate + "|" + stock + "|" + type);
            }

            File.WriteAllLines(path, materialData.ToArray());
            return;
        }

    }
}
