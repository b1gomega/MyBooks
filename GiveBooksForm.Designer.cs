
namespace MyBooks
{
    partial class GiveBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveBooksForm));
            this.AllUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AllBooksDataGridView = new System.Windows.Forms.DataGridView();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButton = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GiveBooksButton = new System.Windows.Forms.Button();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllUsersDataGridView
            // 
            this.AllUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnYear,
            this.ColumnLogin,
            this.ColumnCheckBox});
            this.AllUsersDataGridView.Location = new System.Drawing.Point(13, 36);
            this.AllUsersDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.AllUsersDataGridView.Name = "AllUsersDataGridView";
            this.AllUsersDataGridView.RowHeadersWidth = 51;
            this.AllUsersDataGridView.RowTemplate.Height = 24;
            this.AllUsersDataGridView.Size = new System.Drawing.Size(564, 180);
            this.AllUsersDataGridView.TabIndex = 0;
            this.AllUsersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllUsersDataGridView_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "id";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "surname";
            this.ColumnSurname.MinimumWidth = 6;
            this.ColumnSurname.Name = "ColumnSurname";
            this.ColumnSurname.Width = 75;
            // 
            // ColumnYear
            // 
            this.ColumnYear.HeaderText = "BirthDate";
            this.ColumnYear.MinimumWidth = 6;
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.Width = 75;
            // 
            // ColumnLogin
            // 
            this.ColumnLogin.HeaderText = "UserLogin";
            this.ColumnLogin.Name = "ColumnLogin";
            // 
            // ColumnCheckBox
            // 
            this.ColumnCheckBox.HeaderText = "";
            this.ColumnCheckBox.MinimumWidth = 6;
            this.ColumnCheckBox.Name = "ColumnCheckBox";
            this.ColumnCheckBox.Width = 50;
            // 
            // AllBooksDataGridView
            // 
            this.AllBooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllBooksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurnameColumn,
            this.NameColumn,
            this.YearColumn,
            this.PlaceColumn,
            this.ColumnButton});
            this.AllBooksDataGridView.Location = new System.Drawing.Point(13, 296);
            this.AllBooksDataGridView.Name = "AllBooksDataGridView";
            this.AllBooksDataGridView.RowHeadersWidth = 51;
            this.AllBooksDataGridView.Size = new System.Drawing.Size(563, 201);
            this.AllBooksDataGridView.TabIndex = 4;
            this.AllBooksDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllBooksGridView_CellContentClick);
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
            // PlaceColumn
            // 
            this.PlaceColumn.HeaderText = "Place";
            this.PlaceColumn.MinimumWidth = 6;
            this.PlaceColumn.Name = "PlaceColumn";
            this.PlaceColumn.Width = 75;
            // 
            // ColumnButton
            // 
            this.ColumnButton.HeaderText = "";
            this.ColumnButton.MinimumWidth = 6;
            this.ColumnButton.Name = "ColumnButton";
            this.ColumnButton.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список користувачів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(226, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список книг";
            // 
            // GiveBooksButton
            // 
            this.GiveBooksButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveBooksButton.Location = new System.Drawing.Point(596, 85);
            this.GiveBooksButton.Name = "GiveBooksButton";
            this.GiveBooksButton.Size = new System.Drawing.Size(206, 50);
            this.GiveBooksButton.TabIndex = 8;
            this.GiveBooksButton.Text = "Віддати книги";
            this.GiveBooksButton.UseVisualStyleBackColor = true;
            this.GiveBooksButton.Click += new System.EventHandler(this.GiveBooksButton_Click);
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Location = new System.Drawing.Point(596, 59);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(206, 20);
            this.DaysTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(592, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Повернення через(днів):";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(596, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Повернутися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GiveBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.GiveBooksButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllBooksDataGridView);
            this.Controls.Add(this.AllUsersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GiveBooksForm";
            this.Text = "GetBookToUserForm";
            this.Load += new System.EventHandler(this.GetBookToUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllBooksDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllUsersDataGridView;
        private System.Windows.Forms.DataGridView AllBooksDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GiveBooksButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnButton;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}