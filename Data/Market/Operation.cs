using Newtonsoft.Json;

namespace BITTREX.API.Data.Market
{
	[JsonObject]
	public class Operation
	{
		#region Public properties



		[JsonProperty("uuid")]
		public string Id { get; set; }



		#endregion
	}
}
