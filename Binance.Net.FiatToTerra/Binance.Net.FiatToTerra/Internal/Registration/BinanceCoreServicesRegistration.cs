using Binance.Net.Clients;
using LightInject;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace Binance.FiatToTerra.Internal.Registration
{
    internal class BinanceCoreServicesRegistration
    {

        public static void Register(ServiceContainer container, string apiKey)
        {
            container.RegisterInstance(new BinanceClient(new Net.Objects.BinanceClientOptions()
            {
                ApiCredentials = new Net.Objects.BinanceApiCredentials()
                {

                },
                SpotApiOptions = new Net.Objects.BinanceApiClientOptions()
                {

                }

            }));

        }
    }
}
