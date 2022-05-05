using Study_Xmarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Study_Xmarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}