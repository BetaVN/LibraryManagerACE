﻿namespace Assignment_ACE
{
    partial class MainInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matauthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matpublish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matname,
            this.matauthor,
            this.matpublish,
            this.matstock});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 649);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.removeMaterial);
            // 
            // matname
            // 
            this.matname.HeaderText = "Name";
            this.matname.Name = "matname";
            this.matname.ReadOnly = true;
            this.matname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matname.Width = 300;
            // 
            // matauthor
            // 
            this.matauthor.HeaderText = "Author";
            this.matauthor.Name = "matauthor";
            this.matauthor.ReadOnly = true;
            this.matauthor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matauthor.Width = 300;
            // 
            // matpublish
            // 
            this.matpublish.HeaderText = "Publisher";
            this.matpublish.Name = "matpublish";
            this.matpublish.ReadOnly = true;
            this.matpublish.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matpublish.Width = 300;
            // 
            // matstock
            // 
            this.matstock.HeaderText = "Stock";
            this.matstock.Name = "matstock";
            this.matstock.ReadOnly = true;
            this.matstock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.matstock.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1117, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1117, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1117, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Summary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1117, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(221, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Item Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainInterface";
            this.Text = "Library Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExitProgram);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matname;
        private System.Windows.Forms.DataGridViewTextBoxColumn matauthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn matpublish;
        private System.Windows.Forms.DataGridViewTextBoxColumn matstock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

