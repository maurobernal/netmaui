using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SimpleLogin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Content.BackgroundColor = Color.FromHex("#7698f3");
            BindingContext = GetViewModelAsync();
        }

        private LoginViewModel GetViewModelAsync()
        {
            var model = new LoginViewModel(this);

            return model;
        }

        private  void Button_OnClicked(object sender, EventArgs e)
        {
        }
    }
}
