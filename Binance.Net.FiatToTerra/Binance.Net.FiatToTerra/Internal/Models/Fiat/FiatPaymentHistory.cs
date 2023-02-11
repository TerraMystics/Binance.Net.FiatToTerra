using System.Collections.Generic;

namespace Binance.FiatToTerra.Models.Fiat
{
    public class FiatPaymentHistory : FiatResponse
    {
        public List<FiatPayment> Data { get; set; }
    }
}

