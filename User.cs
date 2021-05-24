using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooks {
    class User {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int year { get; set; }
        public string user_login { get; set; }
        public User(int _id, string _name, string _surname, int _year, string _user_login) {
            id = _id;
            name = _name;
            surname = _surname;
            year = _year;
            user_login = _user_login;
        }
    }
}
