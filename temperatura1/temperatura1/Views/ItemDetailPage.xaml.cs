﻿using System.ComponentModel;
using temperatura1.ViewModels;
using Xamarin.Forms;

namespace temperatura1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}