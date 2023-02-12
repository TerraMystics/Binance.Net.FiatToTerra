using Binance.FiatToTerra.Internal.Constants;
using Binance.FiatToTerra.Internal.Helpers;
using Binance.FiatToTerra.Models.Enums;
using Binance.Net.Clients;

namespace Binance.FiatToTerra.Internal.Clients.Api
{
    internal class WithdrawalsApi
    {
        private readonly BinanceClient binanceClient;
        public WithdrawalsApi(BinanceClient binanceClient)
        {
            this.binanceClient = binanceClient;
        }

        public void ExecuteWithdrawalProcessForTerra(string terraAddress, decimal amount, TerraCoin coinType, StableCoins stable, string memo = "Binance-OnChainTransfer")
        {
            string assetPair = AssetFriendlyNameHelper.GetTerraAssetNameForType(coinType, stable);
            switch (coinType)
            {
                case TerraCoin.USTC:
                    this.binanceClient.SpotApi.Account.WithdrawAsync(assetPair, terraAddress, amount, network: NetworkNames.USTC_NETWORK, name: memo);
                    break;
                case TerraCoin.LUNC:
                    break;
                case TerraCoin.LUNA:
                    break;
            }
        }
    }
}
