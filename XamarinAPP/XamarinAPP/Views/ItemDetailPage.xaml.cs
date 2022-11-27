using System.ComponentModel;
using Xamarin.Forms;
using XamarinAPP.ViewModels;

namespace XamarinAPP.Views
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