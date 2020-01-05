using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass.Models
{
    public class Lecture
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public DateTime dateTime { get; set; }
        public String courseName { get; set; }
        public String filiereName { get; set; }
        [TextBlob("studentsBlobbed")]
        public List<Student> students { get; set; }

        public override string ToString()
        {
            return filiereName + " " + courseName + " " + dateTime;
        }
    }
}
