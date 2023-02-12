using Binance.FiatToTerra.Internal.Clients.Api;

namespace Binance.FiatToTerra.Internal.Clients
{
    internal class BinanceLCD
    {
        public readonly MarketsApi marketing;
        public readonly NetworkingApi networking;
        public readonly SwapsApi swaps;
        public readonly WithdrawalsApi withdrawals;

        public BinanceLCD(MarketsApi marketing, NetworkingApi networking, SwapsApi swaps, WithdrawalsApi withdrawals)
        {
            this.marketing = marketing;
            this.networking = networking;
            this.swaps = swaps;
            this.withdrawals = withdrawals;
        }
    }
}
