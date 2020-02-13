using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HierarchicalNav
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        async void OnNextPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }
       /* async void OnBackPage(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }*/
    }

}