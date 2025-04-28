namespace CryptoExchangeApp.Models
{
    public enum CurrencyType { BTC, ETH, USDT, XRP, DOGE }

    public class Wallet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public CurrencyType Currency { get; set; }
        public double Balance { get; set; }
        public User User { get; set; }
    }
}
