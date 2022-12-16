
using System.Web.Http;
using RestSharp;
using RestSharp.Portable;
using IRestResponse = RestSharp.IRestResponse;
using Method = RestSharp.Method;
using RestRequest = RestSharp.RestRequest;


namespace SpecFlowProjectCoinMarketCap.Helpers
{
    public class  MyController : ApiController
    {
        private readonly RestClient _client;

        public MyController()
        {
            _client = new RestClient();
        }
      
        [HttpGet]
        public IRestResponse Get(String requestUri)
        {
            var request = new RestRequest(requestUri, Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "*/*");
            request.AddHeader("X-CMC_PRO_API_KEY", "f2082379-807d-4fe7-81e6-ad629ed223af");
            request.AddHeader("User-Agent", "PostmanRuntime/7.29.2");
            request.AddHeader("Accept-Encoding", "deflate, gzip, br");
            request.AddHeader("Connection", "keep-alive");
                  
      
            return _client.Execute(request);
        }
      
        [HttpPost]
        public IRestResponse Post(object jsonObject)
        {
            var request = new RestRequest("/api/my-endpoint", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(jsonObject);
      
            return _client.Execute(request);
        }
      
        [HttpDelete]
        public IRestResponse Delete()
        {
            var request = new RestRequest("/api/my-endpoint", Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
      
            return _client.Execute(request);
        }
      
        [HttpPut]
        public IRestResponse Put(object jsonObject)
        {
            var request = new RestRequest("/api/my-endpoint", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(jsonObject);
      
            return _client.Execute(request);
        }
             
    }
}


    