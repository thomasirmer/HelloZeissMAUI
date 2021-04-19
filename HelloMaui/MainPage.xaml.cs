using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace HelloMaui
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage, IPage
    {
        private readonly ZenApiViewModel _zenApiViewModel;

        public MainPage()
        {
            InitializeComponent();
            _zenApiViewModel = new ZenApiViewModel();
            BindingContext = _zenApiViewModel;
        }

        public IView View { get => (IView)Content; set => Content = (View)value; }

        void OnConnect(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                _zenApiViewModel.Connect();
            }
            else
            {
                _zenApiViewModel.Disconnect();
            }
        }
    }
}