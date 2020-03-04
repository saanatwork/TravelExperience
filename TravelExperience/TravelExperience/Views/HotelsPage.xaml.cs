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
    public partial class HotelsPage : ContentPage
    {
        public HotelsPage()
        {
            InitializeComponent();
        }

        private void HomeButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Application.Current.MainPage = new MainPage();
        }
    }
}