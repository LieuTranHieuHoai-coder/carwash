using CarWash.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarWash.Views
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