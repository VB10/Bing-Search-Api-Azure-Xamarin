using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SearchApi
{
	public class ApiHelper
	{
		HttpClient client;
		public ApiHelper()
		{
			client = new HttpClient();
			client.BaseAddress = new Uri("https://api.cognitive.microsoft.com/bing/v5.0/");
			client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key","137e8c96603c46b6aeb78755fd619b58");
		}

		async public Task<Search> getJsonData(string searchdata)
		{

			var response =await client.GetStringAsync("search?q=" + searchdata);

			var result = JsonConvert.DeserializeObject<Search>(response);

			return result;



		}
	}
}
