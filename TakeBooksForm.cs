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
    public partial class TakeBooksForm : Form {
        private Form prev_form;
        public TakeBooksForm(Form PrevForm) {
            InitializeComponent();
            OuterDesign.ChangeForm(this);

            prev_form = PrevForm;
        }
        private void TakeBooksForm_Load(object sender, EventArgs e) {
            List<Book> AllBooks = GetGivenBooks();
            if (AllBooks == null) return; 
            foreach (Book b in AllBooks) {
                    GivenBooksDataGridView.Rows.Add(b.Surname, b.Name, b.Year, b.UserLogin, b.TakingTime.ToShortDateString(), b.ReturningTime.ToShortDateString());
                    if (DateTime.Now >= b.ReturningTime) {
                        int LastRowIndex = GivenBooksDataGridView.Rows.Count - 1;
                        GivenBooksDataGridView.Rows[LastRowIndex].DefaultCellStyle.ForeColor = OuterDesign.WarningСolor;
                    }
                }
            for (int i = 0; i < 5; i++) GivenBooksDataGridView.Columns[i].ReadOnly = true;

            foreach (DataGridViewRow r in GivenBooksDataGridView.Rows) {
                r.Cells[6].Value = false;
            }
        }
        private List<DataGridViewRow> SelectedBookRows = new List<DataGridViewRow>();
        private void GivenBooksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 6) {
                if ((bool)GivenBooksDataGridView[e.ColumnIndex, e.RowIndex].Value == !true) {
                    SelectedBookRows.Add(GivenBooksDataGridView.Rows[e.RowIndex]);
                    GivenBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = true;
                }
                else {
                    SelectedBookRows.Remove(GivenBooksDataGridView.Rows[e.RowIndex]);
                    GivenBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = false;
                }
            }
        }
        //Виведення всіх книг
        private List<Book> GetGivenBooks() {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return null;
            }

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place IS NULL", mysql.GetConnection());
            //(string surname, string name, int year, DateTime taking_time, DateTime returning_time
            List<Book> GivenBooks = new List<Book>();
            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    GivenBooks.Add(new Book(Convert.ToString(reader["surname"]),
                        Convert.ToString(reader["name"]),
                        Convert.ToInt32(reader["year"]),
                        Convert.ToString(reader["UserLogin"]),
                        Convert.ToDateTime(reader["TakingDate"]),
                        Convert.ToDateTime(reader["ReturningDate"])));
                }
            }
            mysql.CloseConnection();
            return GivenBooks;
        }
        private void TakeBooksButton_Click(object sender, EventArgs e) {
            if (SelectedBookRows.Count == 0) {
                MessageBox.Show("Ви не обрали книги");
                return;
            }
            List<DataGridViewRow> DeletedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow r in SelectedBookRows) {
                int? first_place = FirstFreePlace();
              
                if (first_place != null) {
                    MySQL mysql = new MySQL();
                    try {
                        mysql.OpenConnection();
                    }
                    catch {
                        MessageBox.Show("Проблеми з доступом до бази даних!!");
                        this.Close();
                    }
                    string CommandText = "UPDATE `bookslibrarytable` ";
                    CommandText += $"SET place = @p, UserLogin = '', TakingDate = Null, ReturningDate = Null ";
                    CommandText += "WHERE surname = @s AND name = @n AND year = @y AND place IS NULL AND UserLogin = @UL";
                    MySqlCommand command = new MySqlCommand(CommandText, mysql.GetConnection());
                    command.Parameters.AddWithValue("@p", first_place);
                    command.Parameters.AddWithValue("@s", r.Cells[0].Value.ToString());
                    command.Parameters.AddWithValue("@n", r.Cells[1].Value.ToString());
                    command.Parameters.AddWithValue("@y", Convert.ToInt32(r.Cells[2].Value));
                    command.Parameters.AddWithValue("@UL", Convert.ToString(r.Cells[3].Value));
                    command.ExecuteNonQuery();
                    GivenBooksDataGridView.Rows.Remove(r);
                    DeletedRows.Add(r);
                }                
                else {
                    MessageBox.Show("В базі даних нема місць");
                    break;
                }
            }
            foreach (DataGridViewRow r in DeletedRows) SelectedBookRows.Remove(r);
            MessageBox.Show("Книги додано до БД");
        }
        private int? FirstFreePlace() {
            for (int i = 1; i <= 9999; i++) {
                MySQL mysql = new MySQL();
                try {
                    mysql.OpenConnection();
                }
                catch {
                    MessageBox.Show("Проблеми з доступом до бази даних!!");
                    this.Close();
                }
                MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place IS NOT NULL", mysql.GetConnection());
                MySqlDataReader reader = command.ExecuteReader();
                bool RepeatCycle = false;
                while (reader.Read()) {
                    int I = Convert.ToInt32(reader["place"]);
                    if (I == i) {
                        RepeatCycle = true;
                        break;
                    }
                }
                if (RepeatCycle) continue;
                return i;
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }       
    }
}
