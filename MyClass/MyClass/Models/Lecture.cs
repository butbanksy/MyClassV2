using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass.Models
{
    class Lecture
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public String courseName { get; set; }
        public String filiereName { get; set; }
        public List<Student> students { get; set; }
    }
}
