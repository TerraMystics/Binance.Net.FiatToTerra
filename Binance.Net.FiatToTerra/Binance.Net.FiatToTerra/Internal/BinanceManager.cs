using LightInject;
using Binance.FiatToTerra.Internal.Clients;
using Binance.FiatToTerra.Internal.Registration;
using Binance.FiatToTerra.Models.Enums;
using Binance.FiatToTerra.Constants.Http;
using Binance.FiatToTerra.Internal.Models.Configuration;

namespace Binance.FiatToTerra.Internal
{
    internal class BinanceManager
    {
        public ServiceContainer Kernel;

        public BinanceManager InitializeBinanceKernel(
            string apiKey,
            string apiSecret,
            TerraCoin coin,
            StableCoins stable,
            BinanceEnvironment env = BinanceEnvironment.TestNet)
        {
            Kernel = new ServiceContainer();
            InitializeAllServices();
            ConfigureBinanceApiKey(apiKey, apiSecret, env, coin, stable);

            return this;
        }

        private void ConfigureBinanceApiKey(string apiKey, string apiSecret, BinanceEnvironment environment, TerraCoin coin, StableCoins stable)
        {
            string binanceUrl = "";
            switch (BehaviouralConstants.Env = environment)
            {
                case BinanceEnvironment.Mainnet:
                    binanceUrl = BinanceBaseUrls.BINANCE_MAINNET;
                    break;
                case BinanceEnvironment.TestNet:
                    binanceUrl = BinanceBaseUrls.BINANCE_TESTNET;
                    break;
            }
            BinanceCoreServicesRegistration.Register(Kernel, apiKey, apiSecret, binanceUrl, coin, stable);
        }

        public BinanceLCD GetBinanceLCDAccess()
        {
            return Kernel.GetInstance<BinanceLCD>();
        }

        public BinanceClientConfiguration GetBinanceConfiguration()
        {
            return Kernel.GetInstance<BinanceClientConfiguration>();
        }

        private void InitializeAllServices()
        {
            ApiClientRegistration.RegisterApi(Kernel);
        }
    }
}
