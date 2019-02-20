using System;

namespace FinancialCalculator
{
    public class MischievousRounder
    {
        public static decimal Round(decimal number)
        {
            var roundedNumber = Math.Floor(number * 100) / 100;

            var moneyMover = new MoneyMover();
            moneyMover.MoveFractionOfPennyToSecretAccount(number - roundedNumber);

            return roundedNumber;
        }
    }
}
