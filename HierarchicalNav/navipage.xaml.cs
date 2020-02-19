using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HierarchicalNav
{
    public partial class navipage : ContentPage
    {
        public navipage()
        {
            InitializeComponent();
        }

        async void page2 (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }

        async void page3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page4());
        }

        async void pagelast(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }
    }
}
