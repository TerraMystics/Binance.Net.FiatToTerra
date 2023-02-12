using Binance.FiatToTerra.Internal.Constants;
using Binance.FiatToTerra.Models.Enums;
using System;

namespace Binance.FiatToTerra.Internal.Helpers
{
    internal class AssetFriendlyNameHelper
    {
        public static string GetTerraAssetNameForType(TerraCoin coin, StableCoins stable)
        {
            switch (stable)
            {
                case StableCoins.USDT:
                    if (coin == TerraCoin.LUNA)
                    {
                        return TerraAssetPairs.TETHER_TO_LUNA;
                    }
                    else if (coin == TerraCoin.USTC)
                    {
                        throw new ArgumentException("USTC is currently not supported by Tether");
                    }
                    else
                    {
                        return TerraAssetPairs.TETHER_TO_LUNA;
                    }
                case StableCoins.BUSD:
                    if (coin == TerraCoin.LUNA)
                    {
                        return TerraAssetPairs.BUSD_TO_LUNA;
                    }
                    else if (coin == TerraCoin.USTC)
                    {
                        return TerraAssetPairs.BUSD_TO_USTC;
                    }
                    else
                    {
                        return TerraAssetPairs.BUSD_TO_LUNC;
                    }
            }

            throw new ArgumentNullException("Could not find an appropriate asset pair");
        }
    }
}
