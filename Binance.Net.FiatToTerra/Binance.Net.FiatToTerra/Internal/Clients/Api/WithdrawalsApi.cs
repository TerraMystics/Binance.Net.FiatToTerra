using Binance.FiatToTerra.Internal.Helpers;
using Binance.FiatToTerra.Internal.Models.Configuration;
using Binance.Net.Clients;
using System.Threading.Tasks;

namespace Binance.FiatToTerra.Internal.Clients.Api
{
    internal class WithdrawalsApi
    {
        private readonly BinanceClient binanceClient;
        private readonly BinanceClientConfiguration configuration;
        public WithdrawalsApi(BinanceClient binanceClient, BinanceClientConfiguration configuration)
        {
            this.configuration = configuration;
            this.binanceClient = binanceClient;
        }

        public async Task<string> ExecuteWithdrawalProcessForTerra(string terraAddress, decimal amount, string memo)
        {
            string assetPair = AssetFriendlyNameHelper.GetTerraAssetNameForType(this.configuration.Terra, this.configuration.Stable);

            return (await this.binanceClient.SpotApi.Account.WithdrawAsync(assetPair, terraAddress, amount, name: memo)).Data.Id;
        }
    }
}
