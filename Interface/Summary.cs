using Assignment_ACE.Visitor;
using System;
using System.Windows.Forms;

namespace Assignment_ACE.Interface
{
    public partial class Summary : Form
    {
        public SummaryVisitor summary;

        public Summary(SummaryVisitor summary)
        {
            InitializeComponent();
            this.summary = summary;
            initTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            return;
        }

        private void initTable()
        {
            int rowID = dataGridView1.Rows.Add();
            DataGridViewRow newRow = dataGridView1.Rows[rowID];
            newRow.Cells[0].Value = "Books";
            newRow.Cells[1].Value = summary.bookCount.ToString();
            newRow.Cells[2].Value = summary.bookStock.ToString();
            rowID = dataGridView1.Rows.Add();
            newRow = dataGridView1.Rows[rowID];
            newRow.Cells[0].Value = "E-Books";
            newRow.Cells[1].Value = summary.eBookCount.ToString();
            rowID = dataGridView1.Rows.Add();
            newRow = dataGridView1.Rows[rowID];
            newRow.Cells[0].Value = "Video (Physical)";
            newRow.Cells[1].Value = summary.videoPCount.ToString();
            newRow.Cells[2].Value = summary.videoPStock.ToString();
            rowID = dataGridView1.Rows.Add();
            newRow = dataGridView1.Rows[rowID];
            newRow.Cells[0].Value = "Audio (Physical)";
            newRow.Cells[1].Value = summary.audioPCount.ToString();
            newRow.Cells[2].Value = summary.audioPStock.ToString();
            rowID = dataGridView1.Rows.Add();
            newRow = dataGridView1.Rows[rowID];
            newRow.Cells[0].Value = "Video (Digital)";
            newRow.Cells[1].Value = summary.videoDCount.ToString();
            rowID = dataGridView1.Rows.Add();
            newRow = dataGridView1.Rows[rowID];
            newRow.Cells[0].Value = "Audio (Digital)";
            newRow.Cells[1].Value = summary.audioDCount.ToString();

            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}