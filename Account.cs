﻿using System;
namespace Banking.Net5
{
    public class Account
    {

        private static int NextId = 1;
        public int Id { get; set; }
        public double Balance { get; set; }
        public string Description { get; set; }

        public double Withdraw(double amount)
        {
            if(amount <= 0)
            {
                return Balance;
            }
            if(Balance < amount)
            {

            }
        }

        public void print()
        {
            Console.WriteLine($"Id: [{Id}], Balance: [{Balance}], Description: [{Description}]");
        }

        public Account (string Description)
        {
            this.Id = NextId++;
            this.Description = Description;
        }

        public Account()
        {
        }
    }
}