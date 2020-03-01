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

            var historicalplacespage = new MasterPageItem() { Icon = "", Title = "Historycal Places", TargetType = typeof(HistoricalPlacesPage) };
            var hotelspage = new MasterPageItem() { Icon = "", Title = "Hotels", TargetType = typeof(HotelsPage) };
            var restaurantspage = new MasterPageItem() { Icon = "", Title = "Restaurants", TargetType = typeof(RestaurantsPage) };

            menulist.Add(historicalplacespage);
            menulist.Add(hotelspage);
            menulist.Add(restaurantspage);

            navigationDrawerList.ItemsSource = menulist;

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainViewPage)));
            this.BindingContext = new
            {
                Header = "",
                Image = "http://www3.hilton.com/resources/media/hi/GSPSCHF/en_US/img/shared/full_page_image_gallery/main/HH_food_22_675x359_FitToBoxSmallDimension_Center.jpg",
                //Footer = "         -------- Welcome To HotelPlaza --------           "
                Footer = "Welcome To Hotel Plaza"
            };
        }

        private void navigationDrawerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}