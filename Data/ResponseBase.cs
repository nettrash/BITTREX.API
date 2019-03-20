using Newtonsoft.Json;

namespace BITTREX.API.Data
{
	[JsonObject]
	public class ResponseBase
	{
		#region Public properties



		[JsonProperty("success")]
		public bool Result { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }




		#endregion
	}
}
