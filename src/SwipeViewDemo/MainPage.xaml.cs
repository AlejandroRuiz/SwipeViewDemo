using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipeViewDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Demo", "Removing...", "Ok");
        }

        void SwipeItem_Favorite_Invoked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Demo", "Adding to favorites...", "Ok");
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CustomExampleOne());
        }

        void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CustomExampleTwo());
        }

        void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CollectionViewPage());
        }
    }
}
