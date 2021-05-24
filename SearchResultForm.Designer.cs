
namespace MyBooks
{
    partial class SearchResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(176, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Повернутися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Результат пошуку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(46, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сформувати MS Word звіт";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn,
            this.NameColumn,
            this.YearColumn,
            this.PlaceColumn});
            this.BooksDataGridView.Location = new System.Drawing.Point(12, 73);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.RowHeadersWidth = 51;
            this.BooksDataGridView.Size = new System.Drawing.Size(443, 343);
            this.BooksDataGridView.TabIndex = 4;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.Width = 120;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 120;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "SomeAdditionalInfo";
            // 
            // SearchResultForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(467, 591);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BooksDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchResultForm";
            this.Text = "SearchResultForm";
            this.Load += new System.EventHandler(this.SearchResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceColumn;
    }
}