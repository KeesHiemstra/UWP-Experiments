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

namespace MissedPrograms
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    private DateTime MaximumDate = DateTime.Now.Date.AddDays(-1);

    public MainPage()
    {
      this.InitializeComponent();

      PageDate.Date = MaximumDate;
      PageDate.DateFormat = "{dayofweek.full}‎ ‎{month.full}‎ ‎{day.integer} ‎{year.full}";
      PageDate.MaxDate = MaximumDate;
    }

    private void HamburgerButton_Click(object sender, RoutedEventArgs e)
    {
      MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
    }

    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (HomePage.IsSelected)
      {
        //BackButton.Visibility = Visibility.Collapsed;
        MainFrame.Navigate(typeof(HomePage));
      }
    }
  }
}
