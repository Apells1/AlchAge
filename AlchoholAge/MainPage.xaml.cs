using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlchoholAge
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void onAge(object sender, EventArgs e)
        {
            int Age = Convert.ToInt32(agein.Text.ToString());
            int years = 21 - Age;
            Output.Text = ""+years
        }
    }
}
