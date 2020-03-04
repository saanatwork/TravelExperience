using System;
using TravelExperience.Models;
using Xamarin.Forms;
using TravelExperience.Views;
namespace TravelExperience.Views.Behaviors
{
    public class ListViewBehavior : Behavior<ListView>
    {
        ListView listView;

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);

            listView = bindable;
            listView.ItemSelected += ListView_ItemSelected;
        }

        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Item selectedItem = (listView.SelectedItem) as Item;

            Application.Current.MainPage.Navigation.PushModalAsync(new PostPage(selectedItem));
            //Application.Current.MainPage = new NavigationPage(new MainPage());
            //Application.Current.MainPage.Navigation.PushAsync(new PostPage(selectedItem));
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            listView.ItemSelected -= ListView_ItemSelected;
            
        }
    }
}
