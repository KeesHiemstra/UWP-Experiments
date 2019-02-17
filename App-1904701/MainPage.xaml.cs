using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App_1904701
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
      BackButton.Visibility = Visibility.Collapsed;
    }

    private void HamburgerButton_Click(object sender, RoutedEventArgs e)
    {
      MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
      if (MainFrame.CanGoBack)
      {
        MainFrame.GoBack();
        HomePage.IsSelected = true;

      }
    }

    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (HomePage.IsSelected)
      {
        BackButton.Visibility = Visibility.Collapsed;
        MainFrame.Navigate(typeof(HomePage));
      }
      else if (Page1.IsSelected)
      {
        BackButton.Visibility = Visibility.Collapsed;
        MainFrame.Navigate(typeof(Page1));
      }
    }
  }
}
