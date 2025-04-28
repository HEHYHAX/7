using System;

namespace CryptoExchangeApp.Models
{
    public enum OrderType { Buy, Sell }

    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public CurrencyType Currency { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public OrderType OrderType { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
    }
}
