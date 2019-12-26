using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace regiojet_net_api.http
{
    internal static class RegioHttpClient
    {
        #region ENDPOINT_URL
        private const string Protocol = "https";
        private const string Domain = "brn-ybus-pubapi.sa.cz";
        private const string EndpointURL = "restapi/";
        #endregion ENDPOINT_URL

        private static HttpClient _Client;
        private static HttpClient Client
        {
            get
            {
                if(_Client == null)
                {
                    _Client = CreateHttpClient();
                }
                return _Client;
            }
        }

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri($"{Protocol}://{Domain}/{EndpointURL}")
            };
            return client;
        }

        internal static async Task<T> Get<T>(string url, Dictionary<string, string> args)
        {
            var urlBuilder = new StringBuilder(url);
            var argsList = args.ToList();
            for(int i = 0;i < argsList.Count;i++)
            {
                if (i == 0) urlBuilder.Append("?");
                else urlBuilder.Append("&");
                urlBuilder.Append($"{argsList[i].Key}={argsList[i].Value}");
            }
            var response = await Client.GetAsync(urlBuilder.ToString());
            var stringResponse = await response.Content.ReadAsStringAsync();
            var deserialized = JsonConvert.DeserializeObject<T>(stringResponse);
            return deserialized;
        }
    }
}
