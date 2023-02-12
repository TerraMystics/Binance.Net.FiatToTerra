using Binance.FiatToTerra.Models.Enums;

namespace Binance.FiatToTerra.Internal.Models.Configuration
{
    internal class BinanceClientConfiguration
    {
        public StableCoins Stable { get; set; }
        public TerraCoin Terra { get; set; }
    }
}
