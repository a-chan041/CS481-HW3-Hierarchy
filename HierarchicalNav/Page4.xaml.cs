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
        async void ToFinalPage(object sender, EventArgs e) //goes to last page of pets, Suri
        {

            await Navigation.PushAsync(new Page5());
        }

        async void ToPrevious(object sender, EventArgs e) //allows movement to previously visited page
        {

            await Navigation.PopAsync();
        }
        
    }
}
