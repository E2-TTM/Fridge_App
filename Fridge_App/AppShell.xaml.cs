using Fridge_App.ViewModels;
using Fridge_App.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Fridge_App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
