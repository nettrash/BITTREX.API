using Newtonsoft.Json;

namespace BITTREX.API.Data.Stock
{
	[JsonObject]
	public class Order
	{
		#region Public properties



		[JsonProperty("Quantity")]
		public decimal Quantity { get; set; }

		[JsonProperty("Rate")]
		public decimal Rate { get; set; }



		#endregion
	}
}
