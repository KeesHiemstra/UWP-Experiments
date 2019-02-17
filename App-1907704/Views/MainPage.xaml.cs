using System;

using App_1907704.ViewModels;

using Windows.UI.Xaml.Controls;

namespace App_1907704.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
