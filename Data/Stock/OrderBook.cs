using Newtonsoft.Json;

namespace BITTREX.API.Data.Stock
{
	[JsonObject]
	public class OrderBook
	{
		#region Public properties



		[JsonProperty("buy")]
		public Order[] Buy { get; set; }

		[JsonProperty("sell")]
		public Order[] Sell { get; set; }



		#endregion
	}
}
