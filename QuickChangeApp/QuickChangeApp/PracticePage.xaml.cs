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
        Mode currentMode { get; set; }
		public PracticePage ()
		{
			InitializeComponent ();

            score = 0;
            currentMode = Mode.EASY;
            DetermineDifficultyAndCalculateQuestion();

        }
        private void DetermineDifficultyAndCalculateQuestion()
        {
            if (currentMode == Mode.EASY)
            {
                CalculateQuestion(1);
            }
            else if (currentMode == Mode.MEDIUM)
            {
                CalculateQuestion(10);
            }
            else if (currentMode == Mode.HARD)
            {
                CalculateQuestion(100);
            }
        }
        private void CalculateQuestion(int multiplier)
        {
            Random r = new Random();
            amountOwed = Math.Round((Decimal)r.NextDouble() * multiplier, 2);
            amountPaying = Math.Round((Decimal)r.NextDouble() * multiplier + amountOwed, 2);
            QuestionLabel.Text = $"You owe ${amountOwed}.You have ${amountPaying}. How much change will you get back?";
            AnswerEntry.Text = "";
        }
        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(AnswerEntry.Text) == amountPaying - amountOwed)
            {
                ScoreLabel.Text = $"Score: {++score}";

                DetermineDifficultyAndCalculateQuestion();
                AnswerEntry.Text = "";
                ResultLabel.Text = "Correct!!!!!";
                ResultLabel.TextColor = Color.Green;
            }
            else
            {
                ResultLabel.Text = "Sorry! That is incorrect";
                ResultLabel.TextColor = Color.Red;
            }
        }

        private void EasyButton_Clicked(object sender, EventArgs e)
        {
            currentMode = Mode.EASY;
            DetermineDifficultyAndCalculateQuestion();
        }

        private void MediumButton_Clicked(object sender, EventArgs e)
        {
            currentMode = Mode.MEDIUM;
            DetermineDifficultyAndCalculateQuestion();
        }

        private void HardButton_Clicked(object sender, EventArgs e)
        {
            currentMode = Mode.HARD;
            DetermineDifficultyAndCalculateQuestion();
        }
    }
    public enum Mode
    {
        EASY,
        MEDIUM,
        HARD
    }
}