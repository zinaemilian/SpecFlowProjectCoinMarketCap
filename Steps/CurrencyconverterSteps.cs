namespace SpecFlowProjectCoinMarketCap;

[Binding]
public class CurrencyconverterSteps
{
    [Given(@"i try to convert ""(.*)"" ""(.*)"" to ""(.*)""")]
    public void GivenITryToConvertTo(string p0, string p1, string gBP)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"i should see the status code (.*)")]
    public void ThenIShouldSeeTheStatusCode(int p0)
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"i try to convert the amount received in GBP ""(.*)"" to ""(.*)""")]
    public void WhenITryToConvertTheAmountReceivedInGbpTo(string p0, string dOGE)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"i should see the quote price value is increased")]
    public void ThenIShouldSeeTheQuotePriceValueIsIncreased()
    {
        ScenarioContext.StepIsPending();
    }
}