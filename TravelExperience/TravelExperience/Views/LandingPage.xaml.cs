using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelExperience.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            
        }

        
        private void ShowMore_Clicked(object sender, EventArgs e)
        {
            //await((MainPage)App.Current.MainPage).Detail.Navigation.PushAsync(new MainViewPage());
            //Application.Current.MainPage.Navigation.PushAsync(new MainViewPage());
            Navigation.PushAsync(new MainViewPage());
            //await ((MainPage)App.Current.MainPage).Detail.Navigation.PushAsync(new MainViewPage(1, 1));
        }
    }
}