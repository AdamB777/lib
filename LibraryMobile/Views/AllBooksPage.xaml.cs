﻿using LibraryMobile.ViewModels.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LibraryMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AllBooksPage : ContentPage
    {
        public AllBooksPage()
        {
            InitializeComponent();

            BindingContext = new AllBooksViewModel().LoadBooks();
        }
    }
}