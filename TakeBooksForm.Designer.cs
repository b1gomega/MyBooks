
namespace MyBooks {
    partial class TakeBooksForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeBooksForm));
            this.GivenBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TakeBooksButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturningDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButton = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GivenBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GivenBooksDataGridView
            // 
            this.GivenBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GivenBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn,
            this.NameColumn,
            this.YearColumn,
            this.UserLoginColumn,
            this.TakingDateColumn,
            this.ReturningDateColumn,
            this.ColumnButton});
            this.GivenBooksDataGridView.Location = new System.Drawing.Point(12, 36);
            this.GivenBooksDataGridView.Name = "GivenBooksDataGridView";
            this.GivenBooksDataGridView.RowHeadersWidth = 51;
            this.GivenBooksDataGridView.Size = new System.Drawing.Size(622, 201);
            this.GivenBooksDataGridView.TabIndex = 5;
            this.GivenBooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GivenBooksDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список книг";
            // 
            // TakeBooksButton
            // 
            this.TakeBooksButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeBooksButton.Location = new System.Drawing.Point(640, 36);
            this.TakeBooksButton.Name = "TakeBooksButton";
            this.TakeBooksButton.Size = new System.Drawing.Size(206, 50);
            this.TakeBooksButton.TabIndex = 8;
            this.TakeBooksButton.Text = "Повернути книги";
            this.TakeBooksButton.UseVisualStyleBackColor = true;
            this.TakeBooksButton.Click += new System.EventHandler(this.TakeBooksButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(640, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Повернутися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.MinimumWidth = 6;
            this.SurnameColumn.Name = "SurnameColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            // 
            // YearColumn
            // 
            this.YearColumn.HeaderText = "Year";
            this.YearColumn.MinimumWidth = 6;
            this.YearColumn.Name = "YearColumn";
            this.YearColumn.Width = 75;
            // 
            // UserLoginColumn
            // 
            this.UserLoginColumn.HeaderText = "UserLogin";
            this.UserLoginColumn.MinimumWidth = 6;
            this.UserLoginColumn.Name = "UserLoginColumn";
            this.UserLoginColumn.Width = 75;
            // 
            // TakingDateColumn
            // 
            this.TakingDateColumn.HeaderText = "TakingDate";
            this.TakingDateColumn.Name = "TakingDateColumn";
            this.TakingDateColumn.Width = 75;
            // 
            // ReturningDateColumn
            // 
            this.ReturningDateColumn.HeaderText = "ReturningDate";
            this.ReturningDateColumn.Name = "ReturningDateColumn";
            this.ReturningDateColumn.Width = 90;
            // 
            // ColumnButton
            // 
            this.ColumnButton.HeaderText = "";
            this.ColumnButton.MinimumWidth = 6;
            this.ColumnButton.Name = "ColumnButton";
            this.ColumnButton.Width = 50;
            // 
            // TakeBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TakeBooksButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GivenBooksDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TakeBooksForm";
            this.Text = "TakeBooksForm";
            this.Load += new System.EventHandler(this.TakeBooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GivenBooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GivenBooksDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TakeBooksButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLoginColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakingDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturningDateColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnButton;
    }
}