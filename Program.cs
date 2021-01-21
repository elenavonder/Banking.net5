using System;

namespace Banking.Net5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav1 = new Savings(0.12, "My Savings");
            sav1.Deposit(1000);
            sav1.PayInterest(1);

            var sav2 = new Savings(0.12, "My Comp Savings");
            sav2.Deposit(1000);
            sav2.PayInterest(1);

            var acct1 = new Account();

        }
    }
}
