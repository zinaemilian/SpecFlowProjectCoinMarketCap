using System.Net;
using Newtonsoft.Json;
using RestSharp;
using SpecFlowProjectCoinMarketCap.Helpers;
using SpecFlowProjectCoinMarketCap.Models.GetModel;
namespace SpecFlowProjectCoinMarketCap;

[Binding]
public class CurrencyconverterSteps
{
    public IRestResponse response;
    [Given(@"i try to convert ""(.*)"" ""(.*)"" to ""(.*)""")]
    public void GivenITryToConvertTo(string amount, string coinMarketId, string currencyCode)
    {
        GetCurrencyConverter currencyConverter = new GetCurrencyConverter();
        response= currencyConverter.GetGTQtoGBPConversion(amount, coinMarketId, currencyCode);
        Console.WriteLine(response.StatusCode);
        bool code = response.StatusCode == HttpStatusCode.OK;
        Console.WriteLine(code);
        Console.WriteLine("--------////////------");

        var currency = JsonConvert.DeserializeObject<Converter.Response>(response.Content);

        double price = currency.data.Quote["GBP"].Price;
        Console.WriteLine("price is this"+price);
   
    }
    [Then(@"i should see the status code (.*)")]
    public void ThenIShouldSeeTheStatusCode(int p0)
    {
        Console.WriteLine("test");
    }

    [When(@"i try to convert the amount received in GBP ""(.*)"" to ""(.*)""")]
    public void WhenITryToConvertTheAmountReceivedInGbpTo(string p0, string dOGE)
    {
        Console.WriteLine("test");
    }

    [Then(@"i should see the quote price value is increased")]
    public void ThenIShouldSeeTheQuotePriceValueIsIncreased()
    {
        Console.WriteLine("test");
    }
}