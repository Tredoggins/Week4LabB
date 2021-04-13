using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week4LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Label.TextColor == Xamarin.Forms.Color.Blue)
            {
                Label.TextColor = Xamarin.Forms.Color.Red;
            }
            else if (Label.TextColor == Xamarin.Forms.Color.Red)
            {
                Label.TextColor = Xamarin.Forms.Color.Blue;
            }
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            Label.Text = ((Entry)sender).Text;
            Label.BackgroundColor = Xamarin.Forms.Color.Green;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label.Text = e.NewTextValue;
        }
    }
}
