using System;
using System.Collections.Generic;
using System.Text;

namespace QuickChangeApp
{
    class Calculator
    {
        public string CalculateAmountOwed(string owed, string paying)
        {
            var amountOwed = Convert.ToDecimal(owed);
            var amountPayed = Convert.ToDecimal(paying);

            if(amountPayed >= amountOwed)
            {
                return $"Your change is: ${Math.Abs(amountPayed - amountOwed)}";
            }
            else
            {
                return $"You don't have enough money! You are short ${amountOwed - amountPayed}";
            }
        }
    }
    
}
