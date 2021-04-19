﻿using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace HelloMaui
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage, IPage
    {
        public string ConnectionStatus => "Connected";

        public MainPage()
        {
            InitializeComponent();
        }

        public IView View { get => (IView)Content; set => Content = (View)value; }
    }
}
