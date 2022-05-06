using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Study_Xmarin.Views
{
    public class Ch2_ContentPage2 : ContentView
    {
        public Ch2_ContentPage2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}