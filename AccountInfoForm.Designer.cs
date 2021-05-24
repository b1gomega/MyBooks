
namespace MyBooks {
    partial class AccountInfoForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfoForm));
            this.button1 = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(246, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Повернутися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Ім\'я: ";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(12, 40);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(89, 20);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Прізвище: ";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.Location = new System.Drawing.Point(12, 70);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(136, 20);
            this.YearLabel.TabIndex = 4;
            this.YearLabel.Text = "Рік народження: ";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(12, 102);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(57, 20);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Логін: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(228, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Книги із бібліотеки";
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn,
            this.NameColumn,
            this.YearColumn,
            this.TakingDate,
            this.ReturningDate});
            this.BooksDataGridView.Location = new System.Drawing.Point(12, 152);
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.RowHeadersWidth = 51;
            this.BooksDataGridView.Size = new System.Drawing.Size(594, 196);
            this.BooksDataGridView.TabIndex = 7;
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
            // 
            // TakingDate
            // 
            this.TakingDate.HeaderText = "TakingDate";
            this.TakingDate.Name = "TakingDate";
            // 
            // ReturningDate
            // 
            this.ReturningDate.HeaderText = "ReturningDate";
            this.ReturningDate.Name = "ReturningDate";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(376, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Видалити акаунт ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BooksDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountInfoForm";
            this.Text = "AccountInfoForm";
            this.Load += new System.EventHandler(this.AccountInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturningDate;
        private System.Windows.Forms.Button button2;
    }
}