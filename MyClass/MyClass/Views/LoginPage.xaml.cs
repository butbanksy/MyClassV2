using MyClass.Models;
using MyClass.Services;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            LoginIcon.Source = ImageSource.FromResource("MyClass.Resources.TeacherLogo.png");
            init();
        }

        public void init()
        {
            userText.Completed += (s, e) => passwordText.Focus();
            passwordText.Completed += (s, e) => Button_Clicked(s, e);
        }

        private void UserText_Completed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Professor professor = ProfessorServices.checkLogin(userText.Text, passwordText.Text);
            //Console.WriteLine(5+21 + professor == null);
            if (professor != null) // null.
            {
                Navigation.PushAsync(new Home());
            }
            else
            {
                DisplayAlert("Error", "No match found", "OK");
            }
        }

        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

    }
}