using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Toned.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz2 : ContentPage
    {
        public Quiz2()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Continue_Clicked(object sender, EventArgs e)
        {
            if(Age.Text == null)
            {
                await DisplayAlert("Age", "Please enter your age", "OK");
            }
            else
            {
                await Navigation.PushAsync(new QuizHW());
            }

        }
            //Navigation.InsertPageBefore(new MainPage1(), Navigation.NavigationStack[0]);
            //await Navigation.PopToRootAsync();     
    }
}