using Binance.FiatToTerra.Internal.Helpers;
using Binance.FiatToTerra.Internal.Models.Configuration;
using Binance.Net.Clients;
using CryptoExchange.Net.CommonObjects;
using System;
using System.Threading.Tasks;

namespace Binance.FiatToTerra.Internal.Clients.Api
{
    internal class SwapsApi
    {
        private readonly BinanceClient binanceClient;
        private readonly BinanceClientConfiguration configuration;
        public SwapsApi(BinanceClient binanceClient, BinanceClientConfiguration configuration)
        {
            this.configuration = configuration;
            this.binanceClient = binanceClient;
        }

        /// <summary>
        /// Executes a Swap on the Terra Coin according to 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<string> ExecuteBuySwapForAsset(decimal amount)
        {
            string assetName = AssetFriendlyNameHelper.GetTerraAssetNameForType(this.configuration.Terra, this.configuration.Stable);

            var result = await this.binanceClient.SpotApi.CommonSpotClient.PlaceOrderAsync(assetName,
                   CommonOrderSide.Buy, CommonOrderType.Market, amount);
            if (result.Error != null)
            {
                throw new ArgumentException($"Failed to execute Buy Swap for Terra: \n Status Code: {result.Error.Code}, Error: {result.Error.Message}");
            }
            else
            {
                return result.Data.Id;
            }
        }

        /// <summary>
        /// Executes a Swap from the Stable Coin to the Terra Coin. If successful returns the Swap Order ID
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="priceLimit"></param>
        /// <returns></returns>
        public async Task<string> ExecuteBuySwapForAssetWithLimit(decimal amount, decimal priceLimit)
        {
            string assetName = AssetFriendlyNameHelper.GetTerraAssetNameForType(this.configuration.Terra, this.configuration.Stable);

            var result = await this.binanceClient.SpotApi.CommonSpotClient.PlaceOrderAsync(assetName, CommonOrderSide.Buy, CommonOrderType.Limit, amount, priceLimit);
            if (result.Error != null)
            {
                throw new ArgumentException($"Failed to execute Limit Buy Swap for Terra: \n Status Code: {result.Error.Code}, Error: {result.Error.Message}");
            }
            else
            {
                return result.Data.Id;
            }
        }
    }
}
