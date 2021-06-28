using System.ComponentModel;
using Xamarin.Forms;
using XamarinPBKK.ViewModels;

namespace XamarinPBKK.Views
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