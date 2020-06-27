using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeViewDemo
{
    public partial class App : Application
    {
        static App()
        {
            Device.SetFlags(new[] { "SwipeView_Experimental" });
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
