using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExperience.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelExperience.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostPage : ContentPage
    {
        public PostPage()
        {
            InitializeComponent();
        }
        public PostPage(Item item)
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);

            DetailswebView.Source = item.ItemLink;
        }
        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //    Application.Current.MainPage = new MainPage();
        //}
    }
}