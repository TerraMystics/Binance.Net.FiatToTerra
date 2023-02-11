namespace Binance.FiatToTerra.Models.BSwap.Post
{
    public class SwapQuote
    {
        public int SwapId { get; set; }
        public string QuoteAsset { get; set; }
        public string BaseAsset { get; set; }
        public double QuoteQty { get; set; }
        public int RecvWindow { get; set; }
        public int Timestamp { get; set; }
        public string Signature { get; set; }
    }
}
