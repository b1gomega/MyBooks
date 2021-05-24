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
    public partial class GiveBooksForm : Form {
        Form prev_form;
        public GiveBooksForm(Form PrevForm) {
            InitializeComponent();
            prev_form = PrevForm;
            OuterDesign.ChangeForm(this);
            this.AcceptButton = GiveBooksButton;
            
        }
        private void GetBookToUserForm_Load(object sender, EventArgs e) {
            List<Book> AllBooks = GetAllBooks();
            if (AllBooks == null) return;
            foreach (Book b in AllBooks) {
                    AllBooksDataGridView.Rows.Add(b.Surname, b.Name, b.Year, b.Place);
                }
            AllBooksDataGridView.Columns[0].ReadOnly = true;
            AllBooksDataGridView.Columns[1].ReadOnly = true;
            AllBooksDataGridView.Columns[2].ReadOnly = true;
            AllBooksDataGridView.Columns[3].ReadOnly = true;
            foreach (DataGridViewRow r in AllBooksDataGridView.Rows) {
                r.Cells[4].Value = false;
            }
            List<User> AllUsers = GetAllUsers();
            if (AllUsers == null) return;
            foreach (User u in AllUsers) {
                    AllUsersDataGridView.Rows.Add(u.id, u.name, u.surname, u.year, u.user_login);
            }
            AllUsersDataGridView.Columns[0].ReadOnly = true;
            AllUsersDataGridView.Columns[1].ReadOnly = true;
            AllUsersDataGridView.Columns[2].ReadOnly = true;
            AllUsersDataGridView.Columns[3].ReadOnly = true;
            foreach (DataGridViewRow r in AllUsersDataGridView.Rows) {
                r.Cells[5].Value = false;
            }            
        }        
        //Виведення всіх книг
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
        //Виведення всіх користувачів
        private List<User> GetAllUsers() {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return null;
            }

            MySqlCommand command = new MySqlCommand("SELECT * FROM `userinformationtable`", mysql.GetConnection());

            List<User> AllUsers = new List<User>();
            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    AllUsers.Add(new User(Convert.ToInt32(reader["userid"]),
                        Convert.ToString(reader["name"]),
                        Convert.ToString(reader["surname"]),
                        Convert.ToInt32(reader["BirthYear"]),
                        Convert.ToString(reader["login"]))); 
                }
            }
            mysql.CloseConnection();
            return AllUsers;
        }
        private DataGridViewRow SelectedUserkRow;
        private void AllUsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 5) {
                foreach (DataGridViewRow r in AllUsersDataGridView.Rows) {
                    if (r != AllUsersDataGridView.Rows[e.RowIndex]) r.Cells[e.ColumnIndex].Value = false;
                }
                if ((bool)AllUsersDataGridView[e.ColumnIndex, e.RowIndex].Value == !true) {
                    SelectedUserkRow = AllUsersDataGridView.Rows[e.RowIndex];
                    AllUsersDataGridView[e.ColumnIndex, e.RowIndex].Value = true;
                }
                else {
                    SelectedUserkRow = null;
                    AllUsersDataGridView[e.ColumnIndex, e.RowIndex].Value = false;
                }
            }
        }
        private List<DataGridViewRow> SelectedBookRows = new List<DataGridViewRow>(); 
        private void AllBooksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 4) {
                if ((bool)AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value == !true) {
                    SelectedBookRows.Add(AllBooksDataGridView.Rows[e.RowIndex]);
                    AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = true;
                }
                else {
                    SelectedBookRows.Remove(AllBooksDataGridView.Rows[e.RowIndex]);
                    AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = false;
                }                  
            }
        }
        private void GiveBooksButton_Click(object sender, EventArgs e) {
            if (SelectedUserkRow == null) {
                MessageBox.Show("Ви не обрали користувача");
                return;
            }
            else if (SelectedBookRows.Count == 0) {
                MessageBox.Show("Ви не обрали книги");
                return;
            }
            else if (DaysTextBox.Text == "") {
                MessageBox.Show("Не введено кількість днів");
                return;
            }
            try {
                Convert.ToInt32(DaysTextBox.Text);
            }
            catch {
                MessageBox.Show("Не прваильно обрана кількість днів");
                return;
            }

            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return;
            }
            MySqlCommand SearchCommand = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place IS NOT NULL", mysql.GetConnection());
            MySqlDataReader reader = SearchCommand.ExecuteReader();
            int i = 0;
            while (reader.Read()) i++;
            if (i - SelectedBookRows.Count < 10) {
                MessageBox.Show($"У базі даних має бути якнайменш 10 книг?\n Ви не можете видати таку кількість книг: {i - 10}");
                return;
            }            
            mysql.CloseConnection();

            List<DataGridViewRow> DeletedRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow r in SelectedBookRows) {
                try {
                    mysql.OpenConnection();
                }
                catch {
                    MessageBox.Show("Проблеми з доступом до бази даних!!");
                    return;
                }
                string CommandText = "UPDATE `bookslibrarytable` ";
                CommandText += "SET place = Null, UserLogin = @uL, TakingDate = @td, ReturningDate = @rd ";
                CommandText += "WHERE place = @p";

                MySqlCommand command = new MySqlCommand(CommandText, mysql.GetConnection());
                command.Parameters.AddWithValue("@uL", Convert.ToString(SelectedUserkRow.Cells[4].Value));
                command.Parameters.AddWithValue("@td", DateTime.Now);
                command.Parameters.AddWithValue("@rd", DateTime.Now.AddDays(Convert.ToInt32(DaysTextBox.Text)));
                command.Parameters.AddWithValue("@p", Convert.ToInt32(r.Cells[3].Value));
                command.ExecuteNonQuery();

                AllBooksDataGridView.Rows.Remove(r);
                DeletedRows.Add(r);
            }
            foreach(DataGridViewRow r in DeletedRows) SelectedBookRows.Remove(r);
            MessageBox.Show($"Користувач {Convert.ToString(SelectedUserkRow.Cells[4].Value)} отримав книги");
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
