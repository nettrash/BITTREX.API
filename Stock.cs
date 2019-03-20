using System.Threading.Tasks;
using System.Web;

namespace BITTREX.API
{
	public class Stock : Core
	{
		#region Public constructors



		public Stock()
			: base()
		{

		}

		public Stock(string sKey, string sSecret)
			: base(sKey, sSecret)
		{

		}



		#endregion
		#region Public methods



		public async Task<Data.Response<Data.Stock.OrderBook>> GetOrderBookAsync(string sMarket, OrderBookType book, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			string sMethodUrl = GetMethodUrl(Properties.Settings.Default.MethodGetOrderBook);
			string sRequestUrl = $"{sMethodUrl}?market={HttpUtility.UrlEncode(sMarket)}&type={book}";
			string sResponse = await SendRequestAsync(sRequestUrl, false, cancellationToken);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Data.Response<Data.Stock.OrderBook>>(sResponse);
		}

		public async Task<Data.Response<Data.Stock.Ticker>> GetTickerAsync(string sMarket, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			string sMethodUrl = GetMethodUrl(Properties.Settings.Default.MethodGetTicker);
			string sRequestUrl = $"{sMethodUrl}?market={HttpUtility.UrlEncode(sMarket)}";
			string sResponse = await SendRequestAsync(sRequestUrl, false, cancellationToken);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Data.Response<Data.Stock.Ticker>>(sResponse);
		}

		public async Task<Data.Response<Data.Stock.Market[]>> GetMarketsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			string sMethodUrl = GetMethodUrl(Properties.Settings.Default.MethodGetMarkets);
			string sRequestUrl = $"{sMethodUrl}";
			string sResponse = await SendRequestAsync(sRequestUrl, false, cancellationToken);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Data.Response<Data.Stock.Market[]>>(sResponse);
		}

		public async Task<Data.Response<Data.Stock.Currency[]>> GetCurrenciesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			string sMethodUrl = GetMethodUrl(Properties.Settings.Default.MethodGetCurrencies);
			string sRequestUrl = $"{sMethodUrl}";
			string sResponse = await SendRequestAsync(sRequestUrl, false, cancellationToken);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Data.Response<Data.Stock.Currency[]>>(sResponse);
		}



		#endregion
	}
}
//todo: Stock /public/getmarketsummaries
//todo: Stock /public/getmarketsummary
//todo: Stock /public/getmarkethistory