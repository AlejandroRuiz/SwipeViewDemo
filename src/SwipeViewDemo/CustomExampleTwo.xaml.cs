using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipeViewDemo
{
    public partial class CustomExampleTwo : ContentPage
    {
        public CustomExampleTwo()
        {
            InitializeComponent();
        }

        bool isOpen;

        async void SwipeView_SwipeStarted(System.Object sender, Xamarin.Forms.SwipeStartedEventArgs e)
        {
            var hide = _container.ScaleY == 1;

            if (hide)
            {
                await _container.ScaleYTo(0.6, easing: Easing.SinOut);
                isOpen = true;
            }
            else
            {
                await _container.ScaleYTo(1, easing: Easing.SinOut);
                isOpen = false;
            }
        }

        async void SwipeView_SwipeEnded(System.Object sender, Xamarin.Forms.SwipeEndedEventArgs e)
        {
            if (!e.IsOpen)
            {
                await _container.ScaleYTo(1, easing: Easing.SinOut);
                isOpen = false;
            }
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            if (isOpen)
            {
                _awesomeSwipeView.Close();
                await _container.ScaleYTo(1, easing: Easing.SinOut);
                isOpen = false;
            }
            else
            {
                _awesomeSwipeView.Open(OpenSwipeItem.LeftItems);
                await _container.ScaleYTo(0.6, easing: Easing.SinOut);
                isOpen = true;
            }
        }
    }
}
