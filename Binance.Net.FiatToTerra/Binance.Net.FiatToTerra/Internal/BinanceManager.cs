using LightInject;
using Binance.FiatToTerra.Internal.Clients;
using Binance.FiatToTerra.Internal.Registration;
using Binance.FiatToTerra.Models.Enums;
using Binance.FiatToTerra.Constants.Http;

namespace Binance.FiatToTerra.Internal
{
    internal class BinanceManager
    {
        public static string BinanceApiKey { get; set; }
        public static ServiceContainer Kernel;

        public static void InitializeBinanceKernel(
            string apiKey,
            BinanceEnvironment env = BinanceEnvironment.TestNet)
        {
            Kernel = new ServiceContainer();
            InitializeAllServices();
            ConfigureCEXEnvironment(env);
            ConfigureBinanceApiKey(apiKey);
        }

        private static void ConfigureBinanceApiKey(string apiKey)
        {
            BinanceCoreServicesRegistration.Register(Kernel, BehaviouralConstants.BinanceApiKey = apiKey);
        }

        public static BinanceLCD GetBinanceLCDAccess()
        {
            return Kernel.GetInstance<BinanceLCD>();
        }

        private static void InitializeAllServices()
        {
            ApiClientRegistration.RegisterApi(Kernel);
        }

        private static void ConfigureCEXEnvironment(BinanceEnvironment environment)
        {
            switch (BehaviouralConstants.Env = environment)
            {
                case BinanceEnvironment.Mainnet:
                    BehaviouralConstants.BinanceBaseCEXUrl = BinanceBaseUrls.BINANCE_MAINNET;
                    break;
                case BinanceEnvironment.TestNet:
                    BehaviouralConstants.BinanceBaseCEXUrl = BinanceBaseUrls.BINANCE_TESTNET;
                    break;
            }
        }
    }
}
