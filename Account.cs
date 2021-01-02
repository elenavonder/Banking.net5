using System;
namespace Banking.Net5
{
    public class Account
    {

        private static int NextId = 1;
        public int Id { get; set; }
        public double Balance { get; set; }
        public string Description { get; set; }

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
