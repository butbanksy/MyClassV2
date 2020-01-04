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
        int filiereSelected;
        public Absence()
        {
            InitializeComponent();
            var db = new SQLiteConnection(_dbPath);
            TableQuery<Models.Student> tableQuery = db.Table<MyClass.Models.Student>();
            if (tableQuery != null && tableQuery.Count() > 0)
            {
                listView.ItemsSource = tableQuery.OrderBy(x => x.firstName).ToList();
            }

        }

        private void FilierePicker_SelectedIndexChanged(object sender, EventArgs e)
        {

            Picker picker = (Picker)sender;
            filiereSelected = picker.SelectedIndex;
            coursePicker.IsEnabled = true;
            coursePicker.Items.Clear();
            switch (filiereSelected)
            {
                case 0: coursePicker.Items.Add("C#"); coursePicker.Items.Add("Java"); coursePicker.Items.Add("PHP"); coursePicker.Items.Add("Androird"); break;
                case 1: coursePicker.Items.Add("Cazd"); coursePicker.Items.Add("Javzdazda"); coursePicker.Items.Add("PzadHP"); coursePicker.Items.Add("Anzaddroird"); break;
                case 2: coursePicker.Items.Add("Cazdazdaz#"); coursePicker.Items.Add("zadfrezfzerfrava"); coursePicker.Items.Add("PHtrhhehP"); coursePicker.Items.Add("Andazadqscoird"); break;
                case 3: coursePicker.Items.Add("C#"); coursePicker.Items.Add("Java"); coursePicker.Items.Add("PHP"); coursePicker.Items.Add("Androird"); break;

            }
        }
    }
}