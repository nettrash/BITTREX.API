using Newtonsoft.Json;

namespace BITTREX.API.Data.Market
{
	[JsonObject]
	public class Order
	{
		#region Public properties



		[JsonProperty("Uuid")]
		public string UUID { get; set; }

		[JsonProperty("OrderUuid")]
		public string Id { get; set; }

		[JsonProperty("Exchange")]
		public string Market { get; set; }

		[JsonProperty("OrderType")]
		public string Operation { get; set; }

		[JsonProperty("Quantity")]
		public decimal Quantity { get; set; }

		[JsonProperty("QuantityRemaining")]
		public decimal QuantityRemaining { get; set; }

		[JsonProperty("Limit")]
		public decimal Rate { get; set; }

		[JsonProperty("CommissionPaid")]
		public decimal CommissionPaid { get; set; }

		[JsonProperty("Price")]
		public decimal Price { get; set; }

		[JsonProperty("PricePerUnit")]
		public string PricePerUnit { get; set; }

		[JsonProperty("Opened")]
		public string Opened { get; set; }

		[JsonProperty("Closed")]
		public string Closed { get; set; }

		[JsonProperty("CancelInitiated")]
		public bool CancelInitiated { get; set; }

		[JsonProperty("ImmediateOrCancel")]
		public bool ImmediateOrCancel { get; set; }

		[JsonProperty("IsConditional")]
		public bool IsConditional { get; set; }

		[JsonProperty("Condition")]
		public string Condition { get; set; }

		[JsonProperty("ConditionTarget")]
		public string ConditionTarget { get; set; }



		#endregion
	}
}
