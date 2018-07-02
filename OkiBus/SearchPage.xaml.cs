using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OkiBus
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello world. This is the code\n" + StationFrom.GetStationCode(), "Ok");
        }
    }
}
