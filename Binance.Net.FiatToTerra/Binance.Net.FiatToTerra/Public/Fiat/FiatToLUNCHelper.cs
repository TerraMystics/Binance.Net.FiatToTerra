using Binance.FiatToTerra.Internal;
using Binance.FiatToTerra.Models.Enums;

namespace Binance.FiatToTerra.Public.Fiat
{
    public class FiatToLUNCHelper
    {
        public readonly string apiKey;
        public FiatToLUNCHelper(string apiKey, BinanceEnvironment env = BinanceEnvironment.TestNet)
        {
            this.apiKey = apiKey;
            BinanceManager.InitializeBinanceKernel(apiKey, env); // Initialize Kernel Processor
        }

        public FiatToLUNCHelper SwapLUNCFromFiat(string currency, double amount)
        {
            return this;
        }

        public FiatToLUNCHelper SwapLUNCFromStableCoin(StableCoins coinType, double amount)
        {

            return this;
        }

        public void TransferLUNCToTerraStation(string walletAddress, double LUNCAmount)
        {


        }
    }
}
