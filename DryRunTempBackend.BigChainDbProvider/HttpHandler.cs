using System.Net.Http;
using System.Threading.Tasks;

namespace DryRunTempBackend.BigChainDbProvider
{
    public class HttpHandler
    {
        private readonly string _baseUrl;
        public HttpHandler(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        public async Task<string> ExecuteGetRequestAsync(string resourceUrl)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage responseMessage = await client.GetAsync(_baseUrl+ resourceUrl))
            using (HttpContent content = responseMessage.Content)
            {
                string data = await content.ReadAsStringAsync();
                return data;
            }
        }
    }
}
