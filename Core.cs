using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BITTREX.API
{
	public class Core
	{
		#region Protected properties



		protected byte[] _secretKey { get; set; }

		protected string _key { get; set; }



		#endregion
		#region Public constructors



		public Core()
		{
			_secretKey = Encoding.ASCII.GetBytes(Properties.Settings.Default.Secret);
			_key = Properties.Settings.Default.Key;
		}

		public Core(string sKey, string sSecret)
		{
			_secretKey = Encoding.ASCII.GetBytes(sSecret);
			_key = sKey;
		}



		#endregion
		#region Private methods



		private byte[] _hmac(byte[] data)
		{
			System.Security.Cryptography.HMACSHA512 hmac = new System.Security.Cryptography.HMACSHA512(_secretKey);
			return hmac.ComputeHash(data);
		}



		#endregion
		#region Protected methods



		protected string GetMethodUrl(string sMethod)
		{
			return $"{Properties.Settings.Default.Url}{Properties.Settings.Default.Version}/{sMethod}";
		}

		protected async Task<string> SendRequestAsync(string sUrl, bool bUseApiSign = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
		{
			HttpClient http = new HttpClient();
			HttpRequestMessage rq = new HttpRequestMessage(HttpMethod.Get, new Uri(sUrl));
			if (bUseApiSign)
			{
				rq.Headers.Add("APISIGN", String.Concat(Array.ConvertAll(_hmac(Encoding.ASCII.GetBytes(sUrl)), x => x.ToString("X2"))).ToLower());
			}
			HttpResponseMessage response = await http.SendAsync(rq, cancellationToken);
			return await response.Content.ReadAsStringAsync();
		}



		#endregion
	}
}
