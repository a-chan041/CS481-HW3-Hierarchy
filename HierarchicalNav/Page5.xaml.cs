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

        async void BacktoHome(object sender, EventArgs e) //since on last page, pops back to main welcome page
        {
            await Navigation.PopToRootAsync();
        }

        async void Adoption(object sender, EventArgs e) //goes to next page, one page deeper, the adoption page
        {
            await Navigation.PushAsync(new AdoptionPage());
        }
    }
}
