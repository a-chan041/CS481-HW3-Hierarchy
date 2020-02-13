using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HierarchicalNav
{
    public partial class Page5 : ContentPage
    {
        public Page5()
        {
            InitializeComponent();
        }

        async void BacktoHome(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
