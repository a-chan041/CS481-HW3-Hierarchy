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

        async void OnNextPage(object sender, EventArgs e) //goes to next page, Page 4, Moose
        {
            await Navigation.PushAsync(new Page4());
        }
       
    }

}