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
    public partial class EditForm : Form {
        private Form prev_form;
        
        public EditForm(Form PrevForm) {
            InitializeComponent();
            OuterDesign.ChangeForm(this);

            prev_form = PrevForm;            
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
        private void EditForm_Load(object sender, EventArgs e) {
            List<Book> AllBooks = GetAllBooks();
            if (AllBooks != null) foreach (Book b in AllBooks) {
                    AllBooksDataGridView.Rows.Add(b.Surname, b.Name, b.Year, b.Place);
            }
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE place > 0", mysql.GetConnection());

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
        //Кнопка Повернутися
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        private object old_value;
        private void AllBooksDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            old_value = AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value;
        }
        private void AllBooksDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = old_value;
                return;
            }           
            object new_value = AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value;

            MySqlCommand command;
            if (e.ColumnIndex == 2) {
                int int_new_value;
                try {
                    int_new_value = Convert.ToInt32(new_value);
                }
                catch {
                    AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = old_value;
                    MessageBox.Show("Не правильно введено рік");
                    return;
                }
                if (int_new_value < 1800 || int_new_value > DateTime.Now.Year) {
                    AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = old_value;
                    MessageBox.Show("Не правильно введено рік");
                    return;
                }
            }
            else if (e.ColumnIndex == 3) {
                int int_new_value;
                try {
                    int_new_value = Convert.ToInt32(new_value);
                }
                catch {
                    AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = old_value;
                    MessageBox.Show("Не правильно введено місце");
                    return;
                }
                if (int_new_value < 1 || int_new_value > 2999) {
                    AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = old_value;
                    MessageBox.Show("Не правильно введено місце");
                    return;
                }

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                command = new MySqlCommand("SELECT * FROM `bookslibrarytable` WHERE `place` = @uP", mysql.GetConnection());
                command.Parameters.AddWithValue("@uP", int_new_value);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) {
                    AllBooksDataGridView[e.ColumnIndex, e.RowIndex].Value = old_value;
                    MessageBox.Show("Місце вже занято");
                    return;
                }           
            }

            string CommandText = "UPDATE `bookslibrarytable` ";
            if (e.ColumnIndex == 0) {
                CommandText += $"SET surname = @uvar ";
            }
            else if (e.ColumnIndex == 1) {
                CommandText += $"SET name = @uvar ";
            }
            else if (e.ColumnIndex == 2) {
                CommandText += $"SET year = @uvar ";
            }
            else if (e.ColumnIndex == 3) {
                CommandText += $"SET place = @uvar ";
            }                                 
            CommandText += "WHERE `name` = @uN AND `surname` = @uS AND `year` = @uY AND `place` = @uP";

            object[] RowCopy = new object[4];
            for (int i = 0; i < 4; i++) {
                if (i != e.ColumnIndex) RowCopy[i] = AllBooksDataGridView[i, e.RowIndex].Value;
                else RowCopy[i] = old_value;
            }
            mysql.CloseConnection();
            mysql.OpenConnection();
            command = new MySqlCommand(CommandText, mysql.GetConnection());
            command.Parameters.AddWithValue("@uS", RowCopy[0]);
            command.Parameters.AddWithValue("@uN", RowCopy[1]);
            command.Parameters.AddWithValue("@uY", RowCopy[2]);
            command.Parameters.AddWithValue("@uP", RowCopy[3]);
            command.Parameters.AddWithValue("@uvar", new_value);
            command.ExecuteNonQuery();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }


    }
}
