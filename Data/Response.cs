using Newtonsoft.Json;

namespace BITTREX.API.Data
{
	[JsonObject]
	public class Response<T> : ResponseBase
	{
		#region Public properties



		[JsonProperty("result")]
		public T Data { get; set; }



		#endregion
	}
}
