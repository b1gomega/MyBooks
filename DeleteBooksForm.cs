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
    public partial class DeleteBooksForm : Form {
        private Form prev_form;
        public DeleteBooksForm(Form RrevForm) {
            InitializeComponent();
            prev_form = RrevForm;

            OuterDesign.ChangeForm(this);                   
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            //Lines
            using (Graphics g = Graphics.FromHwnd(this.Handle)) {
                using (Pen p = new Pen(OuterDesign.TextAndBorderColor, 1)) {
                    g.DrawLine(p, 12, 59, ClientSize.Width - 12, 59);
                    g.DrawLine(p, 12, 330, ClientSize.Width - 12, 330);
                }
            }
        }
        private void DeleteBooksForm_Load(object sender, EventArgs e) {
            List<Book> AllBooks = GetAllBooks();
            if (AllBooks != null) foreach (Book b in AllBooks) {
                    AllBooksDataGridView.Rows.Add(b.Surname, b.Name, b.Year, b.Place);
            }
            foreach (DataGridViewRow r in AllBooksDataGridView.Rows) {
                DataGridViewButtonCell ButtonCell = (DataGridViewButtonCell)r.Cells[4];
                ButtonCell.Value = "Видалити";
            }
            AllBooksDataGridView.ReadOnly = true;
        }
        //Кнопка Повернутися
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        private List<Book> GetAllBooks() {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return null;
            }
            MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place IS NOT NULL ", mysql.GetConnection());

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
        private void AllBooksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 4) {
                MySQL mysql = new MySQL();
                try {
                    mysql.OpenConnection();
                }
                catch {
                    MessageBox.Show("Проблеми з доступом до бази даних!!");
                    this.Close();
                    return;                    
                }
                MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place IS NOT NULL", mysql.GetConnection());
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read()) i++;
                if (i <= 10) {
                    DialogResult dialogResult = MessageBox.Show($"У базі даних має бути якнайменш 10 книг? Зараз: {i}\nВи хочете видалити всі книги?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        mysql.CloseConnection();
                        mysql.OpenConnection();
                        MySqlCommand DeleteCommand = new MySqlCommand("DELETE FROM `bookslibrarytable` WHERE place IS NOT NULL", mysql.GetConnection());
                        DeleteCommand.ExecuteNonQuery();
                        AllBooksDataGridView.Rows.Clear();
                    }
                }
                else {
                    DialogResult dialogResult = MessageBox.Show("Ви хочете видалити цю книгу?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        DeleteFromDB(e.RowIndex);
                        AllBooksDataGridView.Rows.RemoveAt(e.RowIndex);
                    }
                }                
            }
        }
        private void DeleteFromDB(int RowIndex) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
            }

            MySqlCommand command = new MySqlCommand("DELETE FROM `bookslibrarytable` WHERE `name` = @uN AND `surname` = @uS AND `year` = @uY AND `place` = @uP", mysql.GetConnection());
            command.Parameters.AddWithValue("@uS", AllBooksDataGridView.Rows[RowIndex].Cells[0].Value);
            command.Parameters.AddWithValue("@uN", AllBooksDataGridView.Rows[RowIndex].Cells[1].Value);
            command.Parameters.AddWithValue("@uY", AllBooksDataGridView.Rows[RowIndex].Cells[2].Value);
            command.Parameters.AddWithValue("@uP", AllBooksDataGridView.Rows[RowIndex].Cells[3].Value);
            command.ExecuteNonQuery();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
