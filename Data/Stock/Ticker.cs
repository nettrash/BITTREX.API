using Newtonsoft.Json;

namespace BITTREX.API.Data.Stock
{
	[JsonObject]
	public class Ticker
	{
		#region Public properties



		[JsonProperty("Bid")]
		public decimal BID { get; set; }

		[JsonProperty("Ask")]
		public decimal ASK { get; set; }

		[JsonProperty("Last")]
		public decimal Last { get; set; }



		#endregion
	}
}
