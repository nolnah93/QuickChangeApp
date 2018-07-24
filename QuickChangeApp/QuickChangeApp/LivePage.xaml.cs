using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickChangeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LivePage : ContentPage
	{
		public LivePage ()
		{
			InitializeComponent ();
		}
        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            ResultLabel.Text = calculator.CalculateAmountOwed(OweEntry.Text, PayEntry.Text);

        }
    }
}