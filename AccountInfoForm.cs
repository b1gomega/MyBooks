using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks {
    public partial class AccountInfoForm : Form {
        private Form prev_form;
        private string login;
        private string password;
        public AccountInfoForm(Form PrevForm, string Login, string Password) {
            InitializeComponent();
            OuterDesign.ChangeForm(this);

            prev_form = PrevForm;
            login = Login;
            password = Password;
        }
        private void AccountInfoForm_Load(object sender, EventArgs e) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return;
            }
            using (MySqlCommand GetUserInfo = new MySqlCommand("SELECT * FROM `userinformationtable` WHERE login = @uL and password = @uP", mysql.GetConnection())) {
                GetUserInfo.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                GetUserInfo.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
                MySqlDataReader reader = GetUserInfo.ExecuteReader();
                reader.Read();

                NameLabel.Text += (string)reader["name"];
                SurnameLabel.Text += (string)reader["surname"];
                YearLabel.Text += ((int)reader["BirthYear"]).ToString();
                LoginLabel.Text += (string)reader["login"];
            }
            List<Book> UserBooks = GetUserBooks();
            if (UserBooks != null) foreach (Book b in UserBooks) {
                    BooksDataGridView.Rows.Add(b.Surname, b.Name, b.Year, b.TakingTime.ToShortDateString(), b.ReturningTime.ToShortDateString());
                    if (DateTime.Now >= b.ReturningTime) {
                        int LastRowIndex = BooksDataGridView.Rows.Count - 1;
                        BooksDataGridView.Rows[LastRowIndex].DefaultCellStyle.ForeColor = OuterDesign.WarningСolor;
                    }
                }
            BooksDataGridView.ReadOnly = true;
        }
        public List<Book> GetUserBooks() {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                this.Close();
                return null;
            }
            MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE UserLogin = @uL ", mysql.GetConnection());
            command.Parameters.AddWithValue("@uL", login);

            List<Book> UserBooks = new List<Book>();
            using (MySqlDataReader reader = command.ExecuteReader()) {
                while (reader.Read()) {
                    UserBooks.Add(new Book(Convert.ToString(reader["surname"]),
                        Convert.ToString(reader["name"]),
                        Convert.ToInt32(reader["year"]),
                        Convert.ToDateTime(reader["TakingDate"]),
                        Convert.ToDateTime(reader["ReturningDate"])));
                }
            }
            mysql.CloseConnection();
            return UserBooks;
        }
        //Кнопка Повернутися
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e) {
            if (BooksDataGridView.Rows.Count > 0) {
                MessageBox.Show("Спочатку віддайте книги, які забрали з бібліотеки!!!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Ви впевненні? Ваш акаунт буде видалено!!", "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                MySQL mysql = new MySQL();
                try {
                    mysql.OpenConnection();
                }
                catch {
                    MessageBox.Show("Проблеми з доступом до бази даних!!");
                    this.Close();
                    return;
                }
                MySqlCommand command = new MySqlCommand("DELETE FROM `userinformationtable` WHERE login = @l AND password = @p ", mysql.GetConnection());
                command.Parameters.AddWithValue("@l", login);
                command.Parameters.AddWithValue("@p", password);
                command.ExecuteNonQuery();
                StartMenuForm StartMenu = new StartMenuForm();
                StartMenu.Show();
                this.Close();
                prev_form.Close();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
