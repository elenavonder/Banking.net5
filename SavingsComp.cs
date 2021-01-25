using System;
namespace Banking.Net5
{
    public class SavingsComp
    {
        public Account account { get; private set; } = null;
        public double InterestRate { get; private set; } = 0.01;


        public SavingsComp(double intrate, string description)
        {
            this.account
        }
        public SavingsComp (string description)
        {
            this.account = new Account(description);
        }
        public SavingsComp()
        {
            this.account = new Account();
        }
    }
}
