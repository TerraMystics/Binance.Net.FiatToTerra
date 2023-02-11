namespace Binance.FiatToTerra.Models.BSwap
{
    public class SwapHistory
    {
        public long SwapId { get; set; }
        public long SwapTime { get; set; }
        public int Status { get; set; }
        public int QuoteAsset { get; set; }
        public string BaseAsset { get; set; }
        public double QuoteQty { get; set; }
        public double BaseQty { get; set; }
        public double Price { get; set; }
        public double Fee { get; set; }
    }
}
