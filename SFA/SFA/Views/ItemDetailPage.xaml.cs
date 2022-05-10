using SFA.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SFA.Views
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