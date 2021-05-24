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
    public partial class AddBooksForm : Form {
        Form prev_form;
        public AddBooksForm(Form PrevForm) {
            InitializeComponent();
            prev_form = PrevForm;

            OuterDesign.ChangeForm(this);
            this.CancelButton = button3;
            this.AcceptButton = button2;           
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
        //Кнопка Повернутися
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        //Кнопка Додати
        private void button2_Click(object sender, EventArgs e) {
            if (NameBookField.Text == "" || SurnameAuthorField.Text == "" || YearCreateField.Text == "" || PlaceField.Text == "") {
                MessageBox.Show("Не введено дані");
                return;
            }
            string UserName, UserSurname;
            int UserYear, UserPlace;

            UserName = NameBookField.Text;
            UserSurname = SurnameAuthorField.Text;
            if (UserName.Length > 50) {
                MessageBox.Show("Назва киниги не може бути довше 50 символів");
                return;
            }
            else if (UserSurname.Length > 50) {
                MessageBox.Show("Прізвище автора не може бути довше 50 символів");
                return;
            }
            else if (!int.TryParse(YearCreateField.Text, out UserYear) || UserYear < 1800 || UserYear > DateTime.Now.Year) {
                MessageBox.Show("Не правильно введено рік");
                return;
            }
            else if (!int.TryParse(PlaceField.Text, out UserPlace) || UserPlace < 1 | UserPlace > 2999) {
                MessageBox.Show("Не правильно введено місце  розташування книги");
                return;
            }
            else if (!IsFreePlace(UserPlace)) {
                MessageBox.Show("Це місце вже зайнято");
                return;
            }
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");               
                return;
            }    
            MySqlCommand command = new MySqlCommand("INSERT INTO `bookslibrarytable` (`id`, `surname`, `name`, `year`, `place`) VALUES (NULL, @uS, @uN, @uY, @uP);", mysql.GetConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = UserName;
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = UserSurname;
            command.Parameters.Add("@uY", MySqlDbType.Int32).Value = UserYear;
            command.Parameters.Add("@uP", MySqlDbType.Int32).Value = UserPlace;
            command.ExecuteNonQuery();           

            MessageBox.Show("Дані успішно занесені до бази даних");

            ClearTextBox();
            mysql.CloseConnection();
        }
        //Кнопка Очистити
        private void button3_Click(object sender, EventArgs e) {
            ClearTextBox();
        }
        //Кнопка показати всі книги
        private void button4_Click(object sender, EventArgs e) {
            this.Hide();
            BooksOutputForm booksOutputForm = new BooksOutputForm(this);
            booksOutputForm.Show();
        }
        //Проверка на доступность места в библиотеке
        public bool IsFreePlace(int _place) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                return false;
            }

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE `place` = @uP", mysql.GetConnection());
            command.Parameters.Add("@uP", MySqlDbType.Int32).Value = _place;
            MySqlDataReader reader = command.ExecuteReader();
            
            if (reader.HasRows) {
                return false;
            }
            else {
                return true;
            }
        }
        //Очистка полей
        public void ClearTextBox() {
            NameBookField.Text = "";
            SurnameAuthorField.Text = "";
            YearCreateField.Text = "";
            PlaceField.Text = "";
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            bool close_now = false;
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                base.OnFormClosing(e);
                if (!prev_form.IsDisposed) prev_form.Show();
                return;
            }
            if (!close_now) {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place IS NOT NULL", mysql.GetConnection());
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read()) i++;

                if (i < 10 && i != 0) {
                    DialogResult dialogResult = MessageBox.Show($"У базі даних має бути якнайменш 10 книг. Зараз: {i}\nВи хочете видалити всі книги?", "Підтвердження видалення", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        mysql.CloseConnection();
                        mysql.OpenConnection();
                        command = new MySqlCommand("DELETE FROM `bookslibrarytable` WHERE place IS NOT NULL", mysql.GetConnection());
                        command.ExecuteNonQuery();
                    }
                    else {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
