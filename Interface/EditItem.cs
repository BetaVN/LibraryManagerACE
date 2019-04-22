using Assignment_ACE.DataClass;
using System;
using System.Windows.Forms;

namespace Assignment_ACE.Interface
{
    public partial class ItemDetails : Form
    {
        public MaterialInfo editItem = new MaterialInfo();

        public ItemDetails(MaterialInfo editItem)
        {
            InitializeComponent();
            this.editItem = editItem;
            string editclass = editItem.classname;
            switch (editclass)
            {
                case "Assignment_ACE.Observers.BookObserver":
                    textBox6.Enabled = false;
                    label8.Text = "Book";
                    break;

                case "Assignment_ACE.Observers.EBookObserver":
                    textBox5.Enabled = false;
                    label8.Text = "E-Book";
                    break;

                case "Assignment_ACE.Observers.VideoObserver":
                    if (editItem.isFile)
                    {
                        textBox5.Enabled = false;
                        label8.Text = "Video (Digital)";
                    }
                    else
                    {
                        label8.Text = "Video (Physical)";
                    }
                    break;

                case "Assignment_ACE.Observers.AudioObserver":
                    if (editItem.isFile)
                    {
                        textBox5.Enabled = false;
                        label8.Text = "Audio (Digital)";
                    }
                    else
                    {
                        label8.Text = "Audio (Physical)";
                    }
                    break;
            }
            Refresh();
            ItemData();
            return;
        }

        private void ItemData()
        {
            textBox1.Text = editItem.name;
            textBox2.Text = editItem.author;
            textBox3.Text = editItem.publisher;
            monthCalendar1.SelectionStart = editItem.publishDate;
            monthCalendar1.SelectionEnd = editItem.publishDate;
            if (textBox5.Enabled)
            {
                textBox5.Text = editItem.itemcount.ToString();
            }
            if (textBox6.Enabled)
            {
                textBox6.Text = editItem.type;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void label7_Click(object sender, EventArgs e)
        {
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
                DialogResult confirmation = MessageBox.Show("Do you want to proceed with changing this data?\r\n"
                                        , "Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirmation == DialogResult.OK)
                {
                    editItem.name = name;
                    editItem.author = author;
                    editItem.publisher = publisher;
                    editItem.publishDate = publishDate;
                    editItem.itemcount = stock;
                    editItem.type = type;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
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