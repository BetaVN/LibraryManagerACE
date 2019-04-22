using Assignment_ACE.DataClass;
using System;
using System.Windows.Forms;

namespace Assignment_ACE.Interface
{
    public partial class ShowDetail : Form
    {
        public MaterialInfo selected;

        public ShowDetail(MaterialInfo selected)
        {
            InitializeComponent();
            this.selected = selected;
            viewSelected();
        }

        private void viewSelected()
        {
            textBox1.Text = selected.name;
            textBox2.Text = selected.author;
            textBox3.Text = selected.publisher;
            if (selected.isFile)
            {
                textBox6.Text = selected.type;
                textBox5.Enabled = false;
            }
            else
            {
                textBox5.Text = selected.itemcount.ToString();
                textBox6.Enabled = false;
            }
            switch (selected.classname)
            {
                case "Assignment_ACE.Observers.BookObserver":
                    label8.Text = "Book";
                    break;

                case "Assignment_ACE.Observers.EBookObserver":
                    label8.Text = "E-Book";
                    break;

                case "Assignment_ACE.Observers.VideoObserver":
                    if (selected.isFile)
                    {
                        label8.Text = "Video (Digital)";
                    }
                    else
                    {
                        label8.Text = "Video (Physical)";
                    }
                    break;

                case "Assignment_ACE.Observers.AudioObserver":
                    if (selected.isFile)
                    {
                        label8.Text = "Audio (Digital)";
                    }
                    else
                    {
                        label8.Text = "Audio (Physical)";
                    }
                    break;
            }
            monthCalendar1.SelectionStart = selected.publishDate;
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}