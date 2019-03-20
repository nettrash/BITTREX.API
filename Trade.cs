using System;
using System.Threading.Tasks;
using System.Web;

namespace BITTREX.API
{
	public class Trade : Core
	{
		#region Public constructors



		public Trade()
			: base()
		{

		}

		public Trade(string sKey, string sSecret)
			: base(sKey, sSecret)
		{

		}



		#endregion
		#region Public methods



		public async Task<Data.Response<Data.Market.Order[]>> GetOpenOrdersAsync(string sMarket, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			string sMethodUrl = GetMethodUrl(Properties.Settings.Default.MethodGetOpenOrders);
			string sRequestUrl = $"{sMethodUrl}?apikey={HttpUtility.UrlEncode(_key)}&market={HttpUtility.UrlEncode(sMarket)}&nonce={HttpUtility.UrlEncode(DateTime.Now.ToFileTimeUtc().ToString())}";
			string sResponse = await SendRequestAsync(sRequestUrl, true, cancellationToken);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Data.Response<Data.Market.Order[]>>(sResponse);
		}

		public async Task<Data.Response<Data.Market.Operation>> BuyLimitAsync(string sMarket, decimal nQuantity, decimal nRate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			string sMethodUrl = GetMethodUrl(Properties.Settings.Default.MethodBuyLimit);
			string sRequestUrl = $"{sMethodUrl}?apikey={HttpUtility.UrlEncode(_key)}&market={HttpUtility.UrlEncode(sMarket)}&quantity={nQuantity.ToString("0.00000000", System.Globalization.CultureInfo.InvariantCulture)}&rate={nRate.ToString("0.00000000", System.Globalization.CultureInfo.InvariantCulture)}&nonce={HttpUtility.UrlEncode(DateTime.Now.ToFileTimeUtc().ToString())}";
			string sResponse = await SendRequestAsync(sRequestUrl, true, cancellationToken);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Data.Response<Data.Market.Operation>>(sResponse);
		}

		public async Task<Data.Response<Data.Market.Operation>> SellLimitAsync(string sMarket, decimal nQuantity, decimal nRate, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			string sMethodUrl = GetMethodUrl(Properties.Settings.Default.MethodSellLimit);
			string sRequestUrl = $"{sMethodUrl}?apikey={HttpUtility.UrlEncode(_key)}&market={HttpUtility.UrlEncode(sMarket)}&quantity={nQuantity.ToString("0.00000000", System.Globalization.CultureInfo.InvariantCulture)}&rate={nRate.ToString("0.00000000", System.Globalization.CultureInfo.InvariantCulture)}&nonce={HttpUtility.UrlEncode(DateTime.Now.ToFileTimeUtc().ToString())}";
			string sResponse = await SendRequestAsync(sRequestUrl, true, cancellationToken);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Data.Response<Data.Market.Operation>>(sResponse);
		}



		#endregion
	}
}
