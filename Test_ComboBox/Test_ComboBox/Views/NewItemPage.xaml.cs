using System;
using System.Collections.Generic;
using System.ComponentModel;
using Test_ComboBox.Models;
using Test_ComboBox.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test_ComboBox.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}