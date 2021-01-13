using System;
namespace Banking.Net5
{
    public class Savings : Account
    {

        public double InterestRate { get; protected set; } = 0.01;

        public double CalculateInterest (int months)
        {
            return this.Balance * (this.InterestRate / 12) * months;
        }

        public double PayInterest (int months)
        {
            var intrest = this.CalculateInterest(months);
            Deposit(intrest);
            return intrest;
        }
        public Savings()
        {
        }
    }
}
