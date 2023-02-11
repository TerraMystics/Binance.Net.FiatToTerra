using System;

namespace Binance.FiatToTerra.Models.Fiat
{
    public class FiatOrder
    {
        public Guid OrderNo { get; set; }
        public string FiatCurrency { get; set; }
        public string IndicatedAmount { get; set; }
        public string Amount { get; set; }
        public string TotalFee { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public long CreateTime { get; set; }
        public long UpdateTime { get; set; }
    }
}

