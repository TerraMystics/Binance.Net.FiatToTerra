using Binance.FiatToTerra.Internal.Helpers;
using Binance.FiatToTerra.Models.Enums;
using Binance.Net.Clients;
using System.Threading.Tasks;

namespace Binance.FiatToTerra.Internal.Clients.Api
{
    internal class MarketsApi
    {
        private readonly BinanceClient binanceClient;
        public MarketsApi(BinanceClient binanceClient)
        {
            this.binanceClient = binanceClient;
        }

        public async Task<decimal> GetCurrentMarketPriceForTerra(TerraCoin coinType, StableCoins stable)
        {
            var currentPrice = await this.binanceClient.SpotApi.ExchangeData.GetPriceAsync(AssetFriendlyNameHelper.GetTerraAssetNameForType(coinType, stable));
            return currentPrice.Data.Price;
        }
    }
}
