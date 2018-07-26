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
	public partial class PracticePage : ContentPage
	{
        int score { get; set; }
        decimal amountOwed { get; set; }
        decimal amountPaying { get; set; }
		public PracticePage ()
		{
			InitializeComponent ();

            Random r = new Random();
            score = 0;
            amountOwed = Math.Round((Decimal)r.NextDouble() * 100, 2);
            amountPaying = Math.Round((Decimal)r.NextDouble() * 100 + amountOwed, 2);
            QuestionLabel.Text = $"You owe ${amountOwed}.You have ${amountPaying}. How much change will you get back?";

        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(AnswerEntry.Text) == amountPaying - amountOwed)
            {
                ScoreLabel.Text = $"Score: {++score}";

                Random r = new Random();
                amountOwed = Math.Round((Decimal)r.NextDouble() * 100, 2);
                amountPaying = Math.Round((Decimal)r.NextDouble() * 100 + amountOwed, 2);
                QuestionLabel.Text = $"You owe ${amountOwed}.You have ${amountPaying}. How much change will you get back?";
                AnswerEntry.Text = "";
            }
        }
    }
}