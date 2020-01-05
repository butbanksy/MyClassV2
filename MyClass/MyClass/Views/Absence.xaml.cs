using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace MyClass.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absence : ContentPage
    {
        String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myClass.db3");
        public Absence()
        {
            InitializeComponent();
            getLecturesList();
        }

        private void getLecturesList()
        {
            var db = new SQLiteConnection(_dbPath);
            TableQuery<Models.Lecture> tableQuery = db.Table<MyClass.Models.Lecture>();
            listView.ItemsSource = tableQuery;
        }


        private void ListView_Refreshing(object sender, EventArgs e)
        {
            getLecturesList();
            listView.EndRefresh();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var lecture = e.SelectedItem as Models.Lecture;
            DisplayAlert("Hello", lecture.students.Count.ToString(), "back");
            App.Current.MainPage = new NavigationPage(new UpdateLecture(lecture));
        }
    }
}
