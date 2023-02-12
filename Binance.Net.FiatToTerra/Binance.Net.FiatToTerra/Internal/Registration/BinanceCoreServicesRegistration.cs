using Binance.FiatToTerra.Constants.Http;
using Binance.Net.Clients;
using Binance.Net.Objects;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;
using LightInject;

namespace Binance.FiatToTerra.Internal.Registration
{
    internal class BinanceCoreServicesRegistration
    {
        public static void Register(ServiceContainer container, string apiKey, string apiSecret)
        {
            BinanceClient.SetDefaultOptions(new BinanceClientOptions
            {
                ApiCredentials = new BinanceApiCredentials("API-KEY", "API-SECRET"),
                SpotApiOptions = new BinanceApiClientOptions
                {
                    BaseAddress = BehaviouralConstants.BinanceBaseCEXUrl,
                    RateLimitingBehaviour = RateLimitingBehaviour.Fail
                }
            });

            container.RegisterSingleton<BinanceClient>();
        }
    }
}
