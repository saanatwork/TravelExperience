using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExperience.MenuItems;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelExperience.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public List<MasterPageItem> menulist { get; set; }
        public MainPage()
        {
            InitializeComponent();
            menulist = new List<MasterPageItem>();

            //var historicalplacespage = new MasterPageItem() { Icon = "FlowerIcon", Title = "Historical Places", TargetType = typeof(HistoricalPlacesPage) };
            var hotelspage = new MasterPageItem() { Icon = "HotelIcon", Title = "Hotels", TargetType = typeof(HotelsPage) };
            var restaurantspage = new MasterPageItem() { Icon = "RestaurantsIcon", Title = "Restaurants", TargetType = typeof(RestaurantsPage) };
            var othervenuepage = new MasterPageItem() { Icon = "OthervenueIcon", Title = "Other Venues", TargetType = typeof(OtherVenuesPage) };

            //menulist.Add(historicalplacespage);
            menulist.Add(hotelspage);
            menulist.Add(restaurantspage);
            menulist.Add(othervenuepage);

            navigationDrawerList.ItemsSource = menulist;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(LandingPage)));
            //Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainViewPage)));
            this.BindingContext = new
            {
                Header = "",
                Image = "https://rinnovationlab.com/wp-content/uploads/2020/03/Lingaraj-2.jpg",
                //Footer = "         -------- Welcome To HotelPlaza --------           "
                Footer = "Explore New Odisha"
            };
        }

        private void navigationDrawerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            //Detail = (Page)Activator.CreateInstance(page);
            IsPresented = false;
        }

        
    }
}