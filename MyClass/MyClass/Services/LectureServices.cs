using MyClass.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyClass.Services
{
    class LectureServices
    {
        static String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myClass.db3");

        public static void addLecture(String courseName, DateTime dateTime, String filiereName, List<Student> students)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<Lecture>();

            Console.WriteLine(students.Count);
            var maxPk = db.Table<Lecture>().OrderByDescending(c => c.id).FirstOrDefault();
            Lecture lecture = new Lecture()
            {
                id = (maxPk == null ? 1 : maxPk.id + 1),
                courseName = courseName,
                filiereName = filiereName,
                dateTime= dateTime,
                students = students
            };
            db.Insert(lecture);

        }
    }
}
