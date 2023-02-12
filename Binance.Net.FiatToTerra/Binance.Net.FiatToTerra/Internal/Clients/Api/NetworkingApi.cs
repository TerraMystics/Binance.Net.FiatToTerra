using Binance.Net.Clients;

namespace Binance.FiatToTerra.Internal.Clients.Api
{
    internal class NetworkingApi
    {
        private readonly BinanceClient binanceClient;
        public NetworkingApi(BinanceClient binanceClient)
        {
            this.binanceClient = binanceClient;
        }

    }
}
