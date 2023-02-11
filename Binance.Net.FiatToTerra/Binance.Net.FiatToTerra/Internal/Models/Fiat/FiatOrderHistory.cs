using System.Collections.Generic;

namespace Binance.FiatToTerra.Models.Fiat
{
    public class FiatOrderHistory : FiatResponse
    {
        public List<FiatOrder> Data { get; set; }
    }
}

