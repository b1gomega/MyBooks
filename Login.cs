using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks {
    class Login {
        private string AdminLogin = "admin";
        private string AdminPassword = "admin";
        //Перевірка на правильність введення логіна та паролю
        public bool CheckAdminLoginAndPassword(string _login, string _password) {
            _login = _login.Trim();
            if (AdminLogin == _login && AdminPassword == _password) {
                return true;
            }
            return false;
        }    
        public bool CheckUserLoginAndPassword(string _login, string _password) {
            _login = _login.Trim();
            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                return false;
            }

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `userinformationtable` WHERE login = @uL AND password = @uP", mysql.GetConnection());
            command.Parameters.AddWithValue("@uL", _login);
            command.Parameters.AddWithValue("@uP", _password); 

            using (MySqlDataReader reader = command.ExecuteReader()) {
                bool check;
                if (reader.HasRows) {
                    check = true;
                }
                else {
                    check = false;
                }
                mysql.CloseConnection();
                return check;
            }
        }
    }
}
