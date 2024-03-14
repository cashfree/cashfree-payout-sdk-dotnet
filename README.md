# Cashfree Payout .Net SDK
![GitHub](https://img.shields.io/github/license/cashfree/cashfree-payout-sdk-dotnet) ![Discord](https://img.shields.io/discord/931125665669972018?label=discord) ![GitHub last commit (branch)](https://img.shields.io/github/last-commit/cashfree/cashfree-payout-sdk-dotnet/master) ![GitHub release (with filter)](https://img.shields.io/github/v/release/cashfree/cashfree-payout-sdk-dotnet?label=latest) ![GitHub forks](https://img.shields.io/github/forks/cashfree/cashfree-payout-sdk-go)

The Cashfree Payout .Net SDK offers a convenient solution to access [Cashfree Payout APIs](https://docs.cashfree.com/reference/payouts-version2-apis) from a server-side .Net  applications.



## Documentation

Cashfree's Payout API Documentation - https://docs.cashfree.com/reference/payouts-version2-apis

Learn and understand payout workflows at Cashfree Payments [here](https://docs.cashfree.com/docs/payouts)

Try out our interactive guides at [Cashfree Dev Studio](https://www.cashfree.com/devstudio) !

## Getting Started

### Installation
```bash
dotnet add package cashfree_payout
```
### Configuration

```csharp 


Cashfree.XClientId = "<x-client-id>";
Cashfree.XClientSecret = "<x-client-secret>";
Cashfree.XEnvironment = Cashfree.SANDBOX;
var cashfree = new Cashfree();
var xApiVersion = "2024-01-01";
```

Generate your API keys (x-client-id , x-client-secret) from [Cashfree Merchant Dashboard](https://merchant.cashfree.com/merchants/login)

## Licence

Apache Licensed. See [LICENSE.md](LICENSE.md) for more details