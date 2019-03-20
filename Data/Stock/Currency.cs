using Newtonsoft.Json;

namespace BITTREX.API.Data.Stock
{
	[JsonObject]
	public class Currency
	{
		#region Public properties



		[JsonProperty("Currency")]
		public string Name { get; set; }

		[JsonProperty("CurrencyLong")]
		public string NameLong { get; set; }

		[JsonProperty("MinConfirmation")]
		public int MinConfirmation { get; set; }

		[JsonProperty("TxFee")]
		public decimal TxFee { get; set; }

		[JsonProperty("IsActive")]
		public bool Active { get; set; }

		[JsonProperty("CoinType")]
		public string CoinType { get; set; }

		[JsonProperty("BaseAddress")]
		public string BaseAddress { get; set; }



		#endregion
	}
}
