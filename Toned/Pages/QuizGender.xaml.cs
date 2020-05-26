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
    public partial class QuizGender : ContentPage
    {
        public QuizGender()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Continue_Clicked(object sender, EventArgs e)
        {
            if (PickerGender.SelectedIndex == -1)
            {
                await DisplayAlert("Religion", "Please choose your gender", "OK");
            }
            else
            {
                await Navigation.PushAsync(new QuizReligion());
            }
            
        }

    }
}