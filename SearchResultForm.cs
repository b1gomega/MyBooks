using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace MyBooks {
    public partial class SearchResultForm : Form {
        private Form prev_form;
        private string extra_info;
        List<Book> books; 
        public SearchResultForm(Form PrevForm, List<Book> Books, string ExtraInfo = "") {
            InitializeComponent();
            prev_form = PrevForm;

            OuterDesign.ChangeForm(this);
            extra_info = ExtraInfo;
            books = Books;
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            //Lines
            using (Graphics g = Graphics.FromHwnd(this.Handle)) {
                using (Pen p = new Pen(OuterDesign.TextAndBorderColor, 1)) {
                    g.DrawLine(p, 12, 59, ClientSize.Width - 12, 59);
                    g.DrawLine(p, 12, 510, ClientSize.Width - 12, 510);
                }
            }
        }
        private void SearchResultForm_Load(object sender, EventArgs e) {
            label2.Text = extra_info;
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                this.Close();
                return;
            }

            if (books.Count > 0) {
                foreach (Book b in books) {
                    BooksDataGridView.Rows.Add(b.Surname, b.Name, b.Year, b.Place);
                }
            }
            else {
                BooksDataGridView.Rows.Add("Книг не знайдено");
            }
            BooksDataGridView.ReadOnly = true;
        }
        //Кнопка Повернутися
        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
        //Кнопка Для cформування MS Word File
        private void button2_Click(object sender, EventArgs e) {
            CreateWordFile();
            MessageBox.Show("Звіт з ім'ям MyBooksResult.docx збережений в папці додаку");
        }
        //Створення ворд-файла
        public void CreateWordFile() {
            string WordDocumentPath = "MyBooksResult.docx";
            DocX document = DocX.Create(WordDocumentPath);

            Paragraph paragraph1 = document.InsertParagraph();
            paragraph1.AppendLine("Результати пошуку: ")
                .Font(new Xceed.Document.NET.Font("TimesNewRoman"))
                .FontSize(14);
            Table t = document.AddTable(BooksDataGridView.Rows.Count + 1, BooksDataGridView.Columns.Count);
            t.Alignment = Alignment.left;
            t.Design = TableDesign.ColorfulListAccent6;

            for (int i = 0; i < t.ColumnCount; i++) {
                t.Rows[0].Cells[i].Paragraphs[0].Append(BooksDataGridView.Columns[i].HeaderText)
                    .Font(new Xceed.Document.NET.Font("TimesNewRoman"))
                    .FontSize(16)
                    .Bold();
            }           
            for (int i = 1; i < t.Rows.Count; i++) {
                for (int j = 0; j < t.ColumnCount; j++) {
                    object SomeVal = BooksDataGridView[j, i - 1].Value;
                    if (SomeVal != null) {
                        t.Rows[i].Cells[j].Paragraphs[0].Append(SomeVal.ToString())
                            .Font(new Xceed.Document.NET.Font("TimesNewRoman"))
                            .FontSize(14);
                    }
                }                         
            }
            document.InsertTable(t);

            Paragraph paragraph2 = document.InsertParagraph();
            paragraph2.AppendLine(extra_info)
                .Font(new Xceed.Document.NET.Font("TimesNewRoman"))
                .FontSize(14);
            document.Save();
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            if (!prev_form.IsDisposed) prev_form.Show();
            base.OnFormClosing(e);
        }
    }
}
