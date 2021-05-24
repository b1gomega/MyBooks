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
    public partial class BooksOutputForm : Form {
        private Form prev_form;
        public BooksOutputForm(Form PrevForm) {
            InitializeComponent();
            OuterDesign.ChangeForm(this);
            
            prev_form = PrevForm;
            this.AcceptButton = button1;
        }
        private void BooksOutputForm_Load(object sender, EventArgs e) {
            List<Book> AllBooks = GetAllBooks();
            if (AllBooks != null) foreach (Book b in AllBooks) {
                    AllBooksDataGridView.Rows.Add(b.Surname, b.Name, b.Year, b.Place);
            }
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
        //Кнопка ОК
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        public List<Book> GetAllBooks() {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return null;
            }

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place IS NOT NULL", mysql.GetConnection());

            List<Book> AllBooks = new List<Book>();
            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    AllBooks.Add(new Book(Convert.ToString(reader["surname"]),
                        Convert.ToString(reader["name"]),
                        Convert.ToInt32(reader["year"]),
                        Convert.ToInt32(reader["place"])));
                }
            }
            mysql.CloseConnection();
            return AllBooks;
        }      
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
