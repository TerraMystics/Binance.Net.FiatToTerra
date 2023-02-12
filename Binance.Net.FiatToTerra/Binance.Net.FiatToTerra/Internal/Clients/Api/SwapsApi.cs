using Binance.FiatToTerra.Internal.Helpers;
using Binance.FiatToTerra.Models.Enums;
using Binance.Net.Clients;

namespace Binance.FiatToTerra.Internal.Clients.Api
{
    internal class SwapsApi
    {
        private readonly BinanceClient binanceClient;
        public SwapsApi(BinanceClient binanceClient)
        {
            this.binanceClient = binanceClient;
        }

        public void ExecuteBuySwapForAsset(TerraCoin coinType, double amount, StableCoins stable)
        {
            switch (stable)
            {
                case StableCoins.USDT:
                    this.binanceClient.SpotApi.CommonSpotClient.PlaceOrderAsync(AssetFriendlyNameHelper.GetTerraAssetNameForType(coinType, stable),
                        CryptoExchange.Net.CommonObjects.CommonOrderSide.Buy, CryptoExchange.Net.CommonObjects.CommonOrderType.Market)
                    break;
                case StableCoins.BUSD:
                    break;
            }
        }

        public void ExecuteBuySwapForAssetWithLimit(TerraCoin coinType, double amount, StableCoins stable)
        {
            switch (stable)
            {
                case StableCoins.USDT:
                    this.binanceClient.SpotApi.CommonSpotClient.PlaceOrderAsync(AssetFriendlyNameHelper.GetTerraAssetNameForType(coinType, stable),
                        CryptoExchange.Net.CommonObjects.CommonOrderSide.Buy, CryptoExchange.Net.CommonObjects.CommonOrderType.Limit, amount, )
                    break;
                case StableCoins.BUSD:
                    break;
            }
        }
    }
}
