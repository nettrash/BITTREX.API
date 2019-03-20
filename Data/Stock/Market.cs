using Newtonsoft.Json;
using System;

namespace BITTREX.API.Data.Stock
{
	[JsonObject]
	public class Market
	{
		#region Public properties



		[JsonProperty("MarketCurrency")]
		public string Currency { get; set; }

		[JsonProperty("BaseCurrency")]
		public string Base { get; set; }

		[JsonProperty("MarketCurrencyLong")]
		public string CurrencyLong { get; set; }

		[JsonProperty("BaseCurrencyLong")]
		public string BaseLong { get; set; }

		[JsonProperty("MinTradeSize")]
		public decimal MinimalTrade { get; set; }

		[JsonProperty("MarketName")]
		public string Name { get; set; }

		[JsonProperty("IsActive")]
		public bool Active { get; set; }

		[JsonProperty("Created")]
		public string Created { get; set; }



		#endregion
	}
}