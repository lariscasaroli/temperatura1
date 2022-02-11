using System;
using System.Collections.Generic;
using System.ComponentModel;
using temperatura1.Models;
using temperatura1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace temperatura1.Views
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