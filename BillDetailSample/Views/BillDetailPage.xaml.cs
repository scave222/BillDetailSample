using BillDetailSample.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BillDetailSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BillDetailPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public BillDetailPage()
        {
            InitializeComponent();

            BindingContext = new BillDetailViewModel();
        }

    }
}
