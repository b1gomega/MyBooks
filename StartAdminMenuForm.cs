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
    public partial class StartAdminMenuForm : Form {
        public StartAdminMenuForm() {
            InitializeComponent();
            OuterDesign.ChangeForm(this);
        }
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
        //Кнопка показати всі книги
        public void button1_Click(object sender, EventArgs e) {
            this.Hide();
            BooksOutputForm booksOutputForm = new BooksOutputForm(this);
            booksOutputForm.Show();
        }
        //Кнопка автор Х назва У
        public void button2_Click(object sender, EventArgs e) {
            this.Hide();
            SearchXYVariantForm searchXYVariantForm = new SearchXYVariantForm(this);
            searchXYVariantForm.Show();
        }
        //Кнопка ХХ рік видання      
        public void button3_Click(object sender, EventArgs e) {
            this.Hide();
            SearchXXVariantForm searchXXVariantForm = new SearchXXVariantForm(this);
            searchXXVariantForm.Show();
        }
        //Кнопка додати книги
        private void button4_Click(object sender, EventArgs e) {
            this.Hide();
            AddBooksForm addBooksForm = new AddBooksForm(this);
            addBooksForm.Show();
        }
        //Кнопка видалити книги
        private void button5_Click(object sender, EventArgs e) {
            this.Hide();
            DeleteBooksForm deleteBooksForm = new DeleteBooksForm(this);
            deleteBooksForm.Show();
        }
        //Кнопка редагувати книги
        private void button6_Click(object sender, EventArgs e) {
            this.Hide();
            EditForm editForm = new EditForm(this);
            editForm.Show();
        }
        //Кнопка Видати книги
        private void button8_Click(object sender, EventArgs e) {
            this.Hide();
            GiveBooksForm giveBooksForm = new GiveBooksForm(this);
            giveBooksForm.Show();
        }
        //Кнопка Забрати книги
        private void button7_Click(object sender, EventArgs e) {
            this.Hide();
            TakeBooksForm takeBooksForm = new TakeBooksForm(this);
            takeBooksForm.Show();
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
