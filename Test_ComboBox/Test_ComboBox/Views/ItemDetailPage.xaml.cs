using System.ComponentModel;
using Test_ComboBox.ViewModels;
using Xamarin.Forms;

namespace Test_ComboBox.Views
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