using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyClass.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateLecture : ContentPage
    {
        public UpdateLecture(Models.Lecture lecture)
        {
            InitializeComponent();
            listView.ItemsSource = lecture.students.ToList();
           
        }
    }
}