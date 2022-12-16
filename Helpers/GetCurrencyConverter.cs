using RestSharp;
using RestSharp.Portable;
using SpecFlowProjectCoinMarketCap.Config;
using IRestResponse = RestSharp.IRestResponse;
using Method = RestSharp.Method;
using RestRequest = RestSharp.RestRequest;

namespace SpecFlowProjectCoinMarketCap.Helpers;

public class  GetCurrencyConverter 
{
    public  IRestResponse GetGTQtoGBPConversion(string amount, string coinMarketCapId, string currencyCode)
    {
        var client = new RestClient(Configuration.ConfigurationReader.Get("baseUri"));
        var request = new RestRequest(Configuration.ConfigurationReader.Get("endPoint"), Method.GET);
        request.AddQueryParameter("amount", amount);
        request.AddQueryParameter("id", coinMarketCapId);
        request.AddQueryParameter("convert", currencyCode);
        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Accept", "*/*");
        request.AddHeader("X-CMC_PRO_API_KEY", "f2082379-807d-4fe7-81e6-ad629ed223af");
        request.AddHeader("User-Agent", "PostmanRuntime/7.29.2");
        request.AddHeader("Accept-Encoding", "deflate, gzip, br");
        request.AddHeader("Connection", "keep-alive");
        return client.Execute(request);
    }
}