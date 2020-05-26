using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Toned
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Intro : ContentPage
    {
        public Intro()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LogIn());
        }

        private async void SignIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Quiz1());
        }
    }
}