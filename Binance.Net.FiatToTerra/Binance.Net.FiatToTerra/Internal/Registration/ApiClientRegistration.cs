﻿using Binance.FiatToTerra.Internal.Clients;
using Binance.FiatToTerra.Internal.Clients.Api;
using LightInject;

namespace Binance.FiatToTerra.Internal.Registration
{
    internal static class ApiClientRegistration
    {
        public static void RegisterApi(ServiceContainer container)
        {
            container.RegisterSingleton<MarketsApi>();
            container.RegisterSingleton<SwapsApi>();
            container.RegisterSingleton<WithdrawalsApi>();
            container.RegisterSingleton<NetworkingApi>();
            container.RegisterSingleton<BinanceLCD>();
        }
    }
}
