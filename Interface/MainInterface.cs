using Assignment_ACE.DataClass;
using Assignment_ACE.Interface;
using Assignment_ACE.Manager;
using Assignment_ACE.Observers;
using Assignment_ACE.Visitor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment_ACE
{
    public partial class MainInterface : Form
    {
        private LibraryManager libraryManager = new LibraryManager();
        private List<MaterialInfo> currentMaterialList = new List<MaterialInfo>();
        public SummaryVisitor summary = new SummaryVisitor();

        public MainInterface()
        {
            InitializeComponent();
            currentMaterialList = libraryManager.readList();
            InitializeTable();
        }

        private void InitializeTable()
        {
            foreach (MaterialInfo material in currentMaterialList)
            {
                addRow(material);
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
            return;
        }

        private void removeMaterial(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete the selected material?\r\n"
                                        , "Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmation == DialogResult.OK)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    foreach (MaterialInfo material in currentMaterialList)
                    {
                        string name = material.name;
                        if (material.type.ToLower() != "none")
                        {
                            name += " (" + material.type + ")";
                        }
                        if (name == item.Cells[0].Value.ToString())
                        {
                            this.libraryManager.removeMaterial(material.name, material.type);
                            this.currentMaterialList.Remove(material);
                            break;
                        }
                    }
                }
                //MessageBox.Show(currentMaterialList.Count().ToString());
                //MessageBox.Show(libraryManager.readList().Count().ToString());
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AddItem newForm = new AddItem();
            DialogResult addItem = newForm.ShowDialog();
            if (addItem == DialogResult.OK)
            {
                string name = newForm.returnItem.getName();
                string type = newForm.returnItem.getType();
                string author = newForm.returnItem.getAuthor();
                string publisher = newForm.returnItem.getSource();
                int stock = newForm.returnItem.getStock();
                bool isFile = newForm.returnItem.isDigital();
                DateTime date = newForm.returnItem.getReleaseDate();
                MaterialInfo newItem = new MaterialInfo(name, author, publisher, date, stock, type, isFile, newForm.returnItem.GetType().ToString());
                this.currentMaterialList.Add(newItem);
                this.libraryManager.addMaterial(newForm.returnItem);
                addRow(newItem);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }
            newForm.Dispose();
            return;
        }

        private void addRow(MaterialInfo material)
        {
            int rowID = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[rowID];
            string name = material.name;
            if (material.type.ToLower() != "none" && material.type != "")
            {
                name += " (" + material.type + ")";
            }
            newRow.Cells[0].Value = name;
            newRow.Cells[1].Value = material.author;
            newRow.Cells[2].Value = material.publisher;
            if (material.isFile == false)
            {
                newRow.Cells[3].Value = material.itemcount.ToString();
            }
        }

        private void createSummary()
        {
            List<MaterialInfo> allItem = libraryManager.readList();
            foreach (MaterialInfo material in allItem)
            {
                summary.visit(material);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to edit.");
                return;
            }
            else
            {
                int matID = 0;
                int rowID = dataGridView1.SelectedRows[0].Index;
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    foreach (MaterialInfo material in currentMaterialList)
                    {
                        string name = material.name;
                        if (material.type.ToLower() != "none" && material.type != "")
                        {
                            name += " (" + material.type + ")";
                        }
                        if (name == item.Cells[0].Value.ToString())
                        {
                            matID = currentMaterialList.IndexOf(material);
                            break;
                        }
                    }
                }
                ItemDetails newForm = new ItemDetails(currentMaterialList[matID]);
                DialogResult editItem = newForm.ShowDialog();
                if (editItem == DialogResult.OK)
                {
                    MaterialInfo editedItem = newForm.editItem;
                    libraryManager.notifyUpdate(editedItem);
                    string name = editedItem.name;
                    string type = editedItem.type;
                    string author = editedItem.author;
                    string publisher = editedItem.publisher;
                    int stock = editedItem.itemcount;
                    DateTime date = editedItem.publishDate;
                    currentMaterialList[matID].update(name, author, publisher, date, stock, type);
                    dataGridView1.Rows[rowID].Cells[0].Value = name;
                    dataGridView1.Rows[rowID].Cells[1].Value = author;
                    dataGridView1.Rows[rowID].Cells[2].Value = publisher;
                    if (currentMaterialList[matID].isFile == false)
                    {
                        dataGridView1.Rows[rowID].Cells[3].Value = stock;
                    }
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
                newForm.Dispose();
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createSummary();
            Summary newForm = new Summary(this.summary);
            newForm.Show();
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to view.");
                return;
            }
            else
            {
                int matID = 0;
                int rowID = dataGridView1.SelectedRows[0].Index;
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    foreach (MaterialInfo material in currentMaterialList)
                    {
                        string name = material.name;
                        if (material.type.ToLower() != "none" && material.type != "")
                        {
                            name += " (" + material.type + ")";
                        }
                        if (name == item.Cells[0].Value.ToString())
                        {
                            matID = currentMaterialList.IndexOf(material);
                            break;
                        }
                    }
                }
                ShowDetail newForm = new ShowDetail(currentMaterialList[matID]);
                newForm.Show();
                return;
            }
        }

        private void ExitProgram(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Do you want to exit the program ?\r\n"
                                        , "Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirmation == DialogResult.OK)
            {
                confirmation = MessageBox.Show("Do you want to save ?\r\n"
                               , "Items", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirmation == DialogResult.OK)
                {
                    libraryManager.exitManager();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}