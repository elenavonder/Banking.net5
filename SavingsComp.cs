using System;
namespace Banking.Net5
{
    public class SavingsComp
    {
        public Account account { get; private set; } = null;
        public double InterestRate { get; private set; } = 0.01;


        public SavingsComp()
        {
            this.account = new Account();
        }
    }
}
