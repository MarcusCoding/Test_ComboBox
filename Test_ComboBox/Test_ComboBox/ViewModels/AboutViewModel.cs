using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Test_ComboBox.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Test_ComboBox.ViewModels
{
    public class AboutViewModel : BaseViewModel, INotifyPropertyChanged
    {
        string duration = "Item 1";

        public string Duration
        {
            get => duration; set
            {
                if (value == null)
                    return;
                duration = value;
            }
        }
        public IList<string> Durations => new List<string> { "Item 1", "Item 2", "Item 3" };

        public string Duration2 { get; set; } = "Item 2";
        public IList<string> Durations2 => new List<string> { "Item 1", "Item 2", "Item 3" };

        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => OnPropertyChanged(null));
        }

        public ICommand OpenWebCommand { get; }
    }
}