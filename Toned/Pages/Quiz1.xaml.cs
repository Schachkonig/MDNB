using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toned.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Toned
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Quiz1 : ContentPage
    {

        public Quiz1()
        {
            InitializeComponent();

            
        }   
     
        private async void Continue_Clicked(object sender, EventArgs e)
        {
            if(Name.Text == null)
            {
                await DisplayAlert("Name","Please, enter your name","OK");
            }
            else
            {
                

                await Navigation.PushAsync(new Quiz2());
            }       
        }
    }
}