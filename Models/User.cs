using System;
using System.Collections.Generic;

namespace CryptoExchangeApp.Models
{
    public enum Roles { User, Admin }

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public Roles Role { get; set; }
        public DateTime DateRegistered { get; set; }

        public List<Wallet> Wallets { get; set; }
        public List<Message> SentMessages { get; set; }
        public List<Message> ReceivedMessages { get; set; }
        public List<Review> ReviewsWritten { get; set; }
        public List<Review> ReviewsReceived { get; set; }
        public List<Order> Orders { get; set; }
    }
}
