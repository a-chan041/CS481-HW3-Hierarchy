using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HierarchicalNav
{
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
        }
        async void ToFinalPage(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Page5());
        }

        async void ToPrevious(object sender, EventArgs e)
        {

            await Navigation.PopAsync();
        }
        
    }
}
