using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HierarchicalNav
{
    public partial class AdoptionPage : ContentPage
    {
        public AdoptionPage()
        {
            InitializeComponent();
        }

        async void OnAppearing(object sender, System.EventArgs e)
        {
            await DisplayAlert("Thank You", "for welcoming our furry friend to your furr-ever home", "OK");
        }

    }
  
    
}
