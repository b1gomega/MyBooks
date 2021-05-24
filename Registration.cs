using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBooks {
    class Registration {
        public bool RegisterNewClient(string name, string surname, int BirthYear, string login, string password) {

            MySQL mysql = new MySQL();
            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                return false;
            }

            List<string> passwords = new List<string>();
            List<string> logins = new List<string>();            
            using (MySqlCommand CheckCommand = new MySqlCommand("SELECT * FROM `userinformationtable`", mysql.GetConnection())) {
                MySqlDataReader reader = CheckCommand.ExecuteReader();
                while (reader.Read()) {
                    logins.Add((string)reader["login"]);
                    passwords.Add((string)reader["password"]);
                }
            }
            mysql.CloseConnection();
            if (login.Length < 8) {
                MessageBox.Show("Довжина логіну має бути більше 7 символів");
                return false;
            }
            else if (password.Length < 8) {
                MessageBox.Show("Довжина паролю має бути більше 7 символів");
                return false;
            }
            else if (login.Length > 20) {
                MessageBox.Show("Довжина логіну має бути меньше 21 символа");
                return false;
            }
            else if (password.Length > 20) {
                MessageBox.Show("Довжина паролю має бути меньше 21 символа");
                return false;
            }
            else if (!IsUniqueLogin(logins, login)) {
                MessageBox.Show("Такий логін вже існує");
                return false;
            }
            else if (!IsUniquePassword(passwords, password)) {
                MessageBox.Show("Такий пароль вже існує");
                return false;
            }

            try {
                mysql.OpenConnection();
            }
            catch {
                MessageBox.Show("Проблеми з доступом до бази даних!!");
                return false;
            }
            MySqlCommand command = new MySqlCommand("INSERT INTO `userinformationtable` (`userid`, `name`, `surname`, `BirthYear`, `login`, `password`) VALUES (NULL, @uN, @uS, @uBY, @uL, @uP);", mysql.GetConnection());
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@uBY", MySqlDbType.VarChar).Value = BirthYear;
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
            command.ExecuteNonQuery();
            MessageBox.Show("Ви зареєстровані");
            return true;
        }
        private bool IsUniqueLogin(List<string> logins, string login) {
            foreach (string l in logins) {
                if (l == login) return false;
            }
            return true;
        }
        private bool IsUniquePassword(List<string> passwords, string password) {
            foreach (string pw in passwords) {
                if (pw == password) return false;
            }        
            return true;
        }       
    }
}
