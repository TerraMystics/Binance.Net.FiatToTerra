namespace Binance.FiatToTerra.Models.Fiat
{
    public class FiatPayment : FiatOrder
    {
        public string SourceAmount { get; set; }
        public string ObtainAmount { get; set; }
        public string CryptoCurrency { get; set; }
        public string Price { get; set; }
    }
}

