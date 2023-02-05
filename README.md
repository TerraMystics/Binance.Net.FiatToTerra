<br/>
<p align="center">
    <a href="https://github.com/TerraMystics"><img src="./binance.png" align="center" width=550/></a>
</p>

<p align="center">
A lightweight library to manage swaps/withdrawals from Fiat to LUNC/LUNA via the Binance Exchange, and makes it very easy for Terra developers to migrate liquidity on-chain.

</p>
<br/>

<p align="center">
  <a href="https://github.com/TerraMystics/Binance.Net.FiatToTerra/blob/main/LICENSE">
  <img alt="GitHub" src="https://img.shields.io/github/license/terra-money/terra.js">
  </a>
    
  <a href="https://www.nuget.org/packages/Binance.Net.FiatToTerra">
    <img alt="GitHub" src="https://img.shields.io/nuget/v/Binance.Net.FiatToTerra">
  </a>
  
  <a href="https://www.nuget.org/packages/Binance.Net.FiatToTerra">
    <img alt="GitHub" src="https://img.shields.io/nuget/dt/Binance.Net.FiatToTerra?color=red">
  </a>
</p>

<p align="center">
  <a href="https://docs.terra.money/"><strong>Explore the Docs »</strong></a>
  <br />
  <br/>
  <a href="https://github.com/TerraMystics/Binance.Net.FiatToTerra/tree/main/Binance.Net.FiatToTerra/OnChainPaymentsSimulator">Example App</a>
  ·
  <a href="https://github.com/TerraMystics/Binance.Net.FiatToTerra">API Reference</a>
  ·
  <a href="https://www.nuget.org/packages/Binance.Net.FiatToTerra">NuGet Package</a>
  ·
  <a href="https://github.com/TerraMystics/Binance.Net.FiatToTerra">GitHub</a>
</p>

Helps dApps & developers migrate customer funds from the Binance Exchange to prepare wallets for on-chain transactions & payments.

## Features

- **Written in C#**, with type definitions
- Works with Xamarin, Unity, Asp, and all other frameworks in the .Net Ecosystems
- Makes it easier to manage payments for anyone deploying to the Apple or Google app stores

## Installation & Configuration

Grab the latest version off [NuGet](https://www.nuget.org/packages/Binance.Net.FiatToTerra)

```sh
dotnet add package Binance.Net.FiatToTerra
```

## Usage

This package can be used for Mobile & Web Developers, or SDK Developers looking to extend the Terra Platform

### Manage Payments

```cs
abstract void InitiateSwapsForCurrency(string currencyCode);
abstract void MigrateCustomerFundsForOnChain(string binanceWallet, string terraWallet);
```

## Binance.Net.FiatToTerra For Unity Developers

If you are using Binance.Net.FiatToTerra for Unity, please make sure to install the [following asset](https://github.com/TerraMystics/NuGetForUnity) in your project, and follow the installation instructions above

## License

This software is licensed under the MIT license. See [LICENSE](./LICENSE) for full disclosure.

© 2022 TerraMystics.
