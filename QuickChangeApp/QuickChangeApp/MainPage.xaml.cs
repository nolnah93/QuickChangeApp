using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuickChangeApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void LiveButton_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new LivePage();
            this.Navigation.PushAsync(new LivePage());
        }

        private void PracticeButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
