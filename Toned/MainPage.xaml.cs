using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toned.Pages;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace Toned
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {


        public MainPage()
        {
            InitializeComponent();

            //NavigationPage.SetHasNavigationBar(this, false);
            //NavigationPage.SetHasBackButton(this, false);

            Detail = new NavigationPage(new MainPage1())
            {
                BarBackgroundColor = Color.FromHex("#FFD5E5"),
                //IconImageSource = ImageSource.FromResource("symbol.png")
                
            };
        }
   
        private void Profile_Clicked(object sender, EventArgs e)
        {

        }

        private void Achivements_Clicked(object sender, EventArgs e)
        {

        }

        private void Property_Clicked(object sender, EventArgs e)
        {

        }
    }
}
