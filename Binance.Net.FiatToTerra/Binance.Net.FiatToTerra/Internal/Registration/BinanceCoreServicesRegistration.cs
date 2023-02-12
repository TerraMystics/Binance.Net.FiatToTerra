using Binance.FiatToTerra.Constants.Http;
using Binance.FiatToTerra.Internal.Models.Configuration;
using Binance.FiatToTerra.Models.Enums;
using Binance.Net.Clients;
using Binance.Net.Objects;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;
using LightInject;

namespace Binance.FiatToTerra.Internal.Registration
{
    internal class BinanceCoreServicesRegistration
    {
        public static void Register(ServiceContainer container, string apiKey, string apiSecret, string baseUrl, TerraCoin coin, StableCoins stable)
        {
            BinanceClient.SetDefaultOptions(new BinanceClientOptions
            {
                ApiCredentials = new BinanceApiCredentials(apiKey, apiSecret),
                SpotApiOptions = new BinanceApiClientOptions
                {
                    BaseAddress = baseUrl,
                    RateLimitingBehaviour = RateLimitingBehaviour.Fail
                }
            });

            container.RegisterSingleton<BinanceClient>();
            container.RegisterInstance(new BinanceClientConfiguration()
            {
                Terra = coin,
                Stable = stable
            });
        }
    }
}
