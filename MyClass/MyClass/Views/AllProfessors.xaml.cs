using MyClass.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyClass.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllProfessors : ContentPage
    {
        String _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myClass.db3");

        public AllProfessors()
        {
            InitializeComponent();
            var db = new SQLiteConnection(_dbPath);
            listView.ItemsSource = db.Table<Professor>().OrderBy(x => x.firstName).ToList();
        }
    }
}