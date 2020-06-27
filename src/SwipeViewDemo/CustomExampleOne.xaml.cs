using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipeViewDemo
{
    public partial class CustomExampleOne : ContentPage
    {
        public CustomExampleOne()
        {
            InitializeComponent();
        }

        async void SwipeView_SwipeEnded(System.Object sender, Xamarin.Forms.SwipeEndedEventArgs e)
        {
            if (e.IsOpen)
            {
                _animationView.IsPlaying = true;
                await Task.Delay(5000);
                _awesomeSwipeView.Close();
                _animationView.IsPlaying = false;
            }
            else
            {
                _animationView.IsPlaying = false;
            }
        }
    }
}
