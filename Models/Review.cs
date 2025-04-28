using System;

namespace CryptoExchangeApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ReviewerId { get; set; }
        public int TargetUserId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public User Reviewer { get; set; }
        public User TargetUser { get; set; }
    }
}
