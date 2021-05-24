using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooks {
    public class Book {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int? Place { get; set; }
        public string UserLogin { get; set; }
        public DateTime TakingTime { get; set; }
        public DateTime ReturningTime { get; set; }
        public Book(string surname, string name, int year, string user_login, DateTime taking_time, DateTime returning_time) {
            Surname = surname;
            Name = name;
            Year = year;
            UserLogin = user_login;
            TakingTime = taking_time;
            ReturningTime = returning_time;
        }

        public Book(string surname, string name, int year, DateTime taking_time, DateTime returning_time) {
            Surname = surname;
            Name = name;
            Year = year;
            TakingTime = taking_time;
            ReturningTime = returning_time;
        }
        public Book(string surname, string name, int year, string user_login) {
            Surname = surname;
            Name = name;
            Year = year;
            UserLogin = user_login;
        }
        public Book(string surname, string name, int year, int? place) {
            Surname = surname;
            Name = name;
            Year = year;
            Place = place;
        }
        public Book(string surname, string name, int year) {
            Surname = surname;
            Name = name;
            Year = year;
        }
    }
}
