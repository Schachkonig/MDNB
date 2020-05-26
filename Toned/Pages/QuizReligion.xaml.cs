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
    public partial class QuizReligion : ContentPage
    {
        public QuizReligion()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void CreateAcc_Clicked(object sender, EventArgs e)
        {
            if(PickerReligion.SelectedIndex == -1) 
            {
                await DisplayAlert("Religion","Please choose religion","OK");
            }
            else 
            {
                User NewUser = new User();
                
                

                Navigation.InsertPageBefore(new MainPage1(), Navigation.NavigationStack[0]);
                await Navigation.PopToRootAsync();
            }
            
        }
    }
}