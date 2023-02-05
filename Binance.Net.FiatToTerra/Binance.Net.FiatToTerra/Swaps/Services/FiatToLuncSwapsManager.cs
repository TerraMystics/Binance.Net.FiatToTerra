using System;
using System.Collections.Generic;
using System.Text;

namespace Binance.Net.FiatToTerra.Swaps.Services
{
    public class FiatToLuncSwapsManager : SwapsBaseManager
    {

    }
    public class FiatToLunaSwapsManager : SwapsBaseManager
    {

    }

    public abstract class SwapsBaseManager
    {
        public abstract void LaunchToCryptoSwapFromCurrency(string currency);
        public abstract void RollbackCryptoSwap(string swapId);
        public bool VerifyFundsForWallet(string binanceWallet)
        {
            throw new NotImplementedException();
        }
    }
}
