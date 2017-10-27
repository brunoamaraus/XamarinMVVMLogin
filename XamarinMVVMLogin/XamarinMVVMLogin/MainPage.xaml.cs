using System;
using Xamarin.Forms;
using XamarinMVVMLogin.ViewModels;

namespace XamarinMVVMLogin
{
    public partial class MainPage : ContentPage
    {
        //private MainViewModel ViewModel => BindingContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
