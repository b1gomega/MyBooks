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
    public partial class LoginForm : Form {
        private Form prev_form;
        public LoginForm(Form PrevForm) {
            InitializeComponent();
            prev_form = PrevForm;
            OuterDesign.ChangeForm(this);
            this.CancelButton = button1;
            this.AcceptButton = button2;
            textBox2.PasswordChar = '*';
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
        //Кнопка скасувати
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        //Кнопка OK
        private void button2_Click(object sender, EventArgs e) {
            string Login, Password;
            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("Не введено дані!");
                return;
            }
            Login = textBox1.Text;
            Password = textBox2.Text;
            Login autorization = new Login();

            if (autorization.CheckAdminLoginAndPassword(Login, Password)) {
                MessageBox.Show("Ви успішно ввійшли в систему як адміністратор");
                StartAdminMenuForm f = new StartAdminMenuForm();
                f.Show();
                prev_form.Close();
                this.Close();
            }
            else if (autorization.CheckUserLoginAndPassword(Login, Password)) {
                MessageBox.Show("Ви успішно ввійшли в систему");
                StartUserMenuForm f = new StartUserMenuForm(Login, Password);
                f.Show();
                prev_form.Close();
                this.Close();
            }
            else {
                MessageBox.Show("Неправильний логін або пароль!!!");
                return;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
