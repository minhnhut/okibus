using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OkiBus
{
    public partial class StationInput : ContentView
    {
        public StationInput()
        {
            InitializeComponent();
        }

        public string GetStationCode()
        {
            return StationName.Text;
        }
    }
}
