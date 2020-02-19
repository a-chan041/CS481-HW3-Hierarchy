using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HierarchicalNav
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void OnNextPage (object sender, EventArgs e)
        {

            await Navigation.PushAsync(new navipage());
        }
    }
}
