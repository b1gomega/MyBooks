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
    public partial class StartUserMenuForm : Form {
        private string login;
        private string password;
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            //Lines
            using (Graphics g = Graphics.FromHwnd(this.Handle)) {               
                using (Pen p = new Pen(OuterDesign.TextAndBorderColor, 1)) {
                    g.DrawLine(p, 12, 74, ClientSize.Width / 2 - 25, 74);
                    g.DrawLine(p, ClientSize.Width / 2 + 25, 74, ClientSize.Width - 12, 74);
                    g.DrawLine(p, ClientSize.Width / 2, 9, ClientSize.Width / 2, ClientSize.Height - 9);
                }
            }
        }
        public StartUserMenuForm(string Login, string Password) {
            InitializeComponent();
            OuterDesign.ChangeForm(this);

            login = Login;
            password = Password;
        }
        //Кнопка показати всі книги
        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            BooksOutputForm booksOutputForm = new BooksOutputForm(this);
            booksOutputForm.Show();
        }
        //Кнопка автор Х назва У
        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            SearchXYVariantForm searchXYVariantForm = new SearchXYVariantForm(this);
            searchXYVariantForm.Show();
        }
        //Кнопка ХХ рік видання      
        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            SearchXXVariantForm searchXXVariantForm = new SearchXXVariantForm(this);
            searchXXVariantForm.Show();
        }
        // Особистий кабінет
        private void button4_Click(object sender, EventArgs e) {
            this.Hide();
            AccountInfoForm accountInfoForm = new AccountInfoForm(this, login, password);
            accountInfoForm.Show();
        }
        private void Quit_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Ви хочете вийти з акаунту?", "Підтвердження виходу", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                StartMenuForm StartMenu = new StartMenuForm();
                StartMenu.Show();
                this.Close();
            }           
        }
    }
}
