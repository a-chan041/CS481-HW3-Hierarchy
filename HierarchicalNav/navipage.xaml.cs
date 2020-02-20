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

        async void page2 (object sender, EventArgs e) //takes user to page 2, Athena
        {
            await Navigation.PushAsync(new Page2());
        }

        async void page3(object sender, EventArgs e) //takes user to page 3 (actually named page 4), Moose
        {
            await Navigation.PushAsync(new Page4());
        }

        async void pagelast(object sender, EventArgs e) //takes user to last page, Suri
        {
            await Navigation.PushAsync(new Page5());
        }
    }
}
