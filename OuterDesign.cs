using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks {
    static class OuterDesign {
        #region Properties
        static public Color WindowBackground { get; set; }
        static public Color ButtonBackground { get; set; }
        static public Color TextAndBorderColor { get; set; }
        static public Color WarningСolor { get; set; }
        #endregion
        static OuterDesign() {
            WindowBackground = Color.FromArgb(27, 30, 31);
            ButtonBackground = Color.FromArgb(43, 61, 64);
            TextAndBorderColor = Color.FromArgb(21, 218, 232);
            WarningСolor = Color.FromArgb(255, 0, 0);
        }
        #region Methods
        public static void ChangeAllButtons(Form f) {
            foreach (Control c in f.Controls) {
                if (c is Button) {
                    Button b = (Button)c;
                    b.BackColor = ButtonBackground;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = TextAndBorderColor;
                    b.ForeColor = TextAndBorderColor;
                }
            }
        }
        public static void ChangeAllLabels(Form f) {
            foreach (Control c in f.Controls) {
                if (c is Label) {
                    Label l = (Label)c;
                    l.ForeColor = TextAndBorderColor;
                }
            }
        }
        public static void ChangeAllTextBoxes(Form f) {
            foreach (Control c in f.Controls) {
                if (c is TextBox) {
                    TextBox tb = (TextBox)c;
                    tb.BackColor = ButtonBackground;
                    tb.ForeColor = TextAndBorderColor;
                    
                }
            }
        }
        public static void ChangeAllListBoxes(Form f) {
            foreach (Control c in f.Controls) {
                if (c is ListBox) {
                    ListBox lb = (ListBox)c;
                    lb.BackColor = ButtonBackground;
                    lb.ForeColor = TextAndBorderColor;
                }
            }
        }
        public static void ChangeAllDataGrids(Form f) {
            foreach (Control c in f.Controls) {
                if (c is DataGridView) {
                    DataGridView dg = (DataGridView)c;
                    dg.BackgroundColor = ButtonBackground;
                    dg.DefaultCellStyle.BackColor = ButtonBackground;

                    dg.GridColor = TextAndBorderColor;
                    
                    dg.EnableHeadersVisualStyles = false;
                    dg.ColumnHeadersDefaultCellStyle.BackColor = ButtonBackground;
                    dg.ColumnHeadersDefaultCellStyle.ForeColor = TextAndBorderColor;
                    
                    dg.RowHeadersDefaultCellStyle.BackColor = ButtonBackground;
                    dg.RowHeadersDefaultCellStyle.ForeColor = TextAndBorderColor;

                    dg.ForeColor = TextAndBorderColor;

                    dg.AllowUserToAddRows = false;
                }
            }
        }
        public static void ChangeBackColor(Form f) {
            f.BackColor = WindowBackground;
        }
        public static void ChangeForm(Form f) {
            ChangeAllButtons(f);
            ChangeAllLabels(f);
            ChangeAllTextBoxes(f);
            ChangeAllListBoxes(f);
            ChangeAllDataGrids(f);
            ChangeBackColor(f);
        }
        #endregion
    }
}
