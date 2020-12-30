using System;
namespace Banking.Net5
{
    public class Account
    {

        private static int NextId = 1;
        public int Id { get; set; };

        public Account()
        {
        }
    }
}
