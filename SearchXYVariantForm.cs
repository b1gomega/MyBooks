using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyBooks
{
    public partial class SearchXYVariantForm : Form {
        private Form prev_form;
        private bool ShowPrevForm = true;
        public SearchXYVariantForm(Form PrevForm) {
            InitializeComponent();
            prev_form = PrevForm;

            OuterDesign.ChangeForm(this);
            this.AcceptButton = button1;
            this.CancelButton = button2;
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            //Lines
            using (Graphics g = Graphics.FromHwnd(this.Handle)) {
                using (Pen p = new Pen(OuterDesign.TextAndBorderColor, 1)) {
                    g.DrawLine(p, 12, 59, ClientSize.Width - 12, 59);
                }
            }
        }
        private void SearchXYVariantForm_Load(object sender, EventArgs e) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return;
            }
        }
        //Кнопка Знайти
        public void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "" && textBox2.Text == "") {
                MessageBox.Show("Не введено дані");
                return;
            }
            //Пошук
            string UserName = textBox1.Text;
            string UserSurname = textBox2.Text;           

            List<Book> Books = SearchXY(UserName, UserSurname);
            ShowPrevForm = false;
            this.Close();
            SearchResultForm searchResultForm = new SearchResultForm(prev_form, Books);
            searchResultForm.Show();
        }
        public List<Book> SearchXY(string UserName, string UserSurname) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return null;
            }           

            List<Book> Books = new List<Book>();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM `bookslibrarytable` WHERE name LIKE '%{UserName}%' AND surname LIKE '%{UserSurname}%' AND place IS NOT NULL", mysql.GetConnection());

            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    Books.Add(new Book(Convert.ToString(reader["surname"]),
                     Convert.ToString(reader["name"]),
                     Convert.ToInt32(reader["year"]),
                     Convert.ToInt32(reader["place"])));
                }
            }               
            mysql.CloseConnection();          
            return Books;           
        }

        //Кнопка Скасувати
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed && ShowPrevForm) prev_form.Show();
            base.OnFormClosing(e);
        }    
    }
}
