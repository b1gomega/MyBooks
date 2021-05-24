
namespace MyBooks
{
    partial class BooksOutputForm
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksOutputForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AllBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список Книг";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.button1.Location = new System.Drawing.Point(213, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllBooksDataGridView
            // 
            this.AllBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn,
            this.NameColumn,
            this.YearColumn,
            this.PlaceColumn});
            this.AllBooksDataGridView.Location = new System.Drawing.Point(12, 74);
            this.AllBooksDataGridView.Name = "AllBooksDataGridView";
            this.AllBooksDataGridView.RowHeadersWidth = 51;
            this.AllBooksDataGridView.Size = new System.Drawing.Size(467, 226);
            this.AllBooksDataGridView.TabIndex = 3;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.Width = 125;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 125;
            // 
            // YearColumn
            // 
            this.YearColumn.HeaderText = "Year";
            this.YearColumn.MinimumWidth = 6;
            this.YearColumn.Name = "YearColumn";
            this.YearColumn.Width = 75;
            // 
            // PlaceColumn
            // 
            this.PlaceColumn.HeaderText = "Place";
            this.PlaceColumn.MinimumWidth = 6;
            this.PlaceColumn.Name = "PlaceColumn";
            this.PlaceColumn.Width = 75;
            // 
            // BooksOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 368);
            this.Controls.Add(this.AllBooksDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BooksOutputForm";
            this.Text = "BooksOutput";
            this.Load += new System.EventHandler(this.BooksOutputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView AllBooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceColumn;
    }
}