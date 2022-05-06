using Study_Xmarin.Services;
using Study_Xmarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Study_Xmarin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            //MainPage = new Ch2_ContentPage();
            MainPage = new NavigationPage( new Ch3_Toolbar());
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
