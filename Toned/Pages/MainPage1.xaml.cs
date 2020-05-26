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
    public partial class MainPage1 : ContentPage
    {
        static bool Check = true;

        public string Name1;
        public int Age1;
        public bool Gender1;
        public double Weight1;
        public double Height1;
        public string Religion1;

        public MainPage1()
        {
            InitializeComponent();

            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            Bum();
        }

        async void Bum()
        {
            if (Check == true)
            {
                await Navigation.PushAsync(new Intro());
            }
            Check = false;
        }
    }
}