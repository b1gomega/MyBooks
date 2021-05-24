
using System;

namespace MyBooks
{
    partial class StartAdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartAdminMenuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Функції програми";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показати всі книги";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(442, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Функції адміністратора";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button2.Location = new System.Drawing.Point(12, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Знайти автора Х книги У";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button3.Location = new System.Drawing.Point(12, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Знайти кількість книг ХХ року видання";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button4.Location = new System.Drawing.Point(442, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(380, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Додати книги";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button5.Location = new System.Drawing.Point(442, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(380, 50);
            this.button5.TabIndex = 5;
            this.button5.Text = "Видалити книги";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button6.Location = new System.Drawing.Point(442, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(380, 50);
            this.button6.TabIndex = 6;
            this.button6.Text = "Редагувати книги";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button7.Location = new System.Drawing.Point(442, 393);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(380, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "Забрати книги";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.button8.Location = new System.Drawing.Point(442, 332);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(380, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "Видати книги";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quit});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(848, 24);
            this.Menu.TabIndex = 11;
            this.Menu.Text = "Menu";
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(52, 20);
            this.Quit.Text = "Вийти";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // StartAdminMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(848, 473);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartAdminMenuForm";
            this.Text = "StartMenuAfterAutorization";
            this.Load += new System.EventHandler(this.StartMenuAfterAutorizationForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void StartMenuAfterAutorizationForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Quit;
    }
}