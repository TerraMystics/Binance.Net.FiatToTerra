namespace Binance.FiatToTerra.Models.Fiat
{
    public class FiatResponse
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public int Total { get; set; }
        public bool Success { get; set; }
    }
}

