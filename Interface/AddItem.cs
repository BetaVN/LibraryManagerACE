using Assignment_ACE.DataClass;
using Assignment_ACE.Manager;
using Assignment_ACE.Observers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_ACE.Interface
{
    public partial class AddItem : Form
    {
        public BaseObserver returnItem { get; set; }

        public AddItem()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            textBox6.Enabled = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            return;
        }

        public void StockCondition(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 4 || comboBox1.SelectedIndex == 5)
            {          
                textBox5.Enabled = false;
                textBox6.Enabled = true;
            }
            else
            {
                textBox5.Enabled = true;
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox6.Enabled = false;
                }
                else
                {
                    textBox6.Enabled = true;
                }
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool errorCheck = Validation();
            if (errorCheck)
            {
                return;
            }
            else
            {
                string classname = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                string name = textBox1.Text;
                string author = textBox2.Text;
                string publisher = textBox3.Text;
                DateTime publishDate = monthCalendar1.SelectionStart;
                int stock = 0;
                if (textBox5.Enabled)
                {
                    stock = Int16.Parse(textBox5.Text);
                }
                string type = "";
                if (textBox6.Enabled)
                {
                    type = textBox6.Text;
                }
                bool isDigital = false;
                switch (classname)
                {
                    case "Book":
                        BookObject newBook = new BookObject(name, author, publisher, publishDate, stock);
                        returnItem = new BookObserver(newBook);
                        break;
                    case "E-Book":
                        EBookObject newEBook = new EBookObject(name, author, publisher, publishDate);
                        returnItem = new EBookObserver(newEBook);
                        break;
                    case "Video (Physical)":
                    case "Video (Digital)":
                        if (classname.Contains("Digital"))
                        {
                            isDigital = true;
                        }
                        VideoObject newVideo = new VideoObject(name, type, author, publishDate, publisher, isDigital, stock);
                        returnItem = new VideoObserver(newVideo);
                        break;
                    case "Audio (Physical)":
                    case "Audio (Digital)":
                        if (classname.Contains("Digital"))
                        {
                            isDigital = true;
                        }
                        AudioObject newAudio = new AudioObject(name, type, author, publishDate, publisher, isDigital, stock);
                        returnItem = new AudioObserver(newAudio);
                        break;
                    default:
                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
        }

        private bool Validation()
        {
            string errors = "Please resolve these errors:@@";
            bool result = false;
            if (textBox1.Text == "")
            {
                errors += "Name can't be empty.@";
                result = true;
            }
            if (textBox2.Text == "")
            {
                errors += "Author name can't be empty.@";
                result = true;
            }
            if (textBox3.Text == "")
            {
                errors += "Publisher name can't be empty.@";
                result = true;
            }
            if (textBox5.Enabled)
            {
                if (!int.TryParse(textBox5.Text, out int n))
                {
                    errors += "Stock must be a number.@";
                    result = true;
                }
            }
            errors = errors.Replace("@", Environment.NewLine);
            if (result)
            {
                MessageBox.Show(errors);
            }
            return result;
        }
    }
}
