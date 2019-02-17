using System;
using System.Collections.ObjectModel;

using App_1907704.Core.Models;
using App_1907704.Core.Services;
using App_1907704.Helpers;

namespace App_1907704.ViewModels
{
    public class DataGridViewModel : Observable
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
