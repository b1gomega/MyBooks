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
    public partial class RegistrationForm : Form {
        private Form prev_form;
        public RegistrationForm(Form PrevForm) {
            InitializeComponent();
            prev_form = PrevForm;
            OuterDesign.ChangeForm(this);
            PasswordUserField.PasswordChar = '*';
            PasswordUserAgainField.PasswordChar = '*';
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
        //Кнопка Повернутися
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        //Кнопка Зареєструватися
        private void button2_Click(object sender, EventArgs e) {
            if (NameUserField.Text == "" || SurnameUserField.Text == "" || YearUserField.Text == "" || LoginUserField.Text == "" || PasswordUserField.Text == "") {
                MessageBox.Show("Не введено дані");
                return;
            }
            string UserName, UserSurname, UserLogin, UserPassword;
            int UserYear;

            UserName = NameUserField.Text.Trim();
            UserSurname = SurnameUserField.Text.Trim();
            UserLogin = LoginUserField.Text.Trim();
            UserPassword = PasswordUserField.Text.Trim();

            if (!int.TryParse(YearUserField.Text, out UserYear) || UserYear < 1940 || UserYear > DateTime.Now.Year) {
                MessageBox.Show("Не правильно введено рік");
                return;
            }            
            else if (PasswordUserAgainField.Text != PasswordUserField.Text) {
                MessageBox.Show("Введені паролі не співпадають!!");
                return;
            }
            Registration reg = new Registration();
            if (reg.RegisterNewClient(UserName, UserSurname, UserYear, UserLogin, UserPassword)) {
                this.Close();
            }                    
        }        
        public void ClearText() {
            NameUserField.Text = "";
            SurnameUserField.Text = "";
            YearUserField.Text = "";
            LoginUserField.Text = "";
            PasswordUserField.Text = "";
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
