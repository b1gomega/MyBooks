using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks {
    public partial class SearchXXVariantForm : Form {
        private Form prev_form;
        private bool ShowPrevForm = true;
        public SearchXXVariantForm(Form PrevForm) {
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
        private void SearchXXVariantForm_Load(object sender, EventArgs e) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
            }
        }      
        //Кнопка знайти
        public void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                MessageBox.Show("Не введено дані");
                return;
            }
            int UserYear;
            if (!int.TryParse(textBox1.Text, out UserYear) || UserYear < 1800 || UserYear > DateTime.Now.Year) {
                MessageBox.Show("Не правильно введено рік");
                textBox1.Clear();
                return;
            }

            List<Book> Books = SearchXX(UserYear);
            string ExtraLine;
            if (Books != null) ExtraLine = $"Знайдена кількість книг: {Books.Count}";
            else ExtraLine = $"Знайдена кількість книг: {0}";
            ShowPrevForm = false;
            this.Close();
            SearchResultForm searchResultForm = new SearchResultForm(prev_form, Books, ExtraLine);
            searchResultForm.Show();
        }
        //Кнопка скасувати
        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }
        public List<Book> SearchXX(int UserYear) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return null;
            }
            List<Book> AllBooks = new List<Book>();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place > 0", mysql.GetConnection());

            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    AllBooks.Add(new Book(Convert.ToString(reader["surname"]),
                        Convert.ToString(reader["name"]), 
                        Convert.ToInt32(reader["year"]), 
                        Convert.ToInt32(reader["place"])));
                }
            }
            mysql.CloseConnection();

            List<Book> NeededBooks = new List<Book>();
            for (int i = 0; i < AllBooks.Count; i++) {
                if (AllBooks[i].Year == UserYear) {
                    NeededBooks.Add(AllBooks[i]);
                }
            }
            return NeededBooks;           
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed && ShowPrevForm) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
