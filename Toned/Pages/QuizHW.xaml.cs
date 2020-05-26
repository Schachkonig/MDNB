using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Toned.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizHW : ContentPage
    {
        public QuizHW()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Continue_Clicked(object sender, EventArgs e)
        {
            if(Height.Text == null || Weight.Text == null)
            {
                await DisplayAlert("", "Please enter your height and weight correctly", "OK");
            }
            else
            {
                await Navigation.PushAsync(new QuizGender());
            }
            
        }
    }
}