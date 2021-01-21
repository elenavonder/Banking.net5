using System;

namespace Banking.Net5
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav1 = new Savings(0.12, "My Savings");
            sav1.Deposit(1000);


        }
    }
}
