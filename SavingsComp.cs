﻿using System;
namespace Banking.Net5
{
    public class SavingsComp
    {
        public Account account { get; private set; } = null;
        public double InterestRate { get; private set; } = 0.01;


        public void print()
        {
            Console.WriteLine($"IntRate: [{this.InterestRate}], Balance: [{account.Balance}], Description: [{account.Description}]");
        }

        public SavingsComp(double intrate, string description)
        {
            this.account = new Account(description);
            this.InterestRate = intrate;
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
