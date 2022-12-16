namespace SpecFlowProjectCoinMarketCap.Models.GetModel;

public class Converter
{
    public class Response
    {
        public Status status { get; set; }
        public Data data { get; set; }
    }

    public class Status
    {
        public string timestamp { get; set; }
        public int error_code { get; set; }
        public object error_message { get; set; }
        public int elapsed { get; set; }
        public int credit_count { get; set; }
        public object notice { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public string last_updated { get; set; }
        public Dictionary<string, Quote> Quote { get; set; }
    }

    public class Quote
    {
        public double Price { get; set; }
        public string LastUpdated { get; set; }
    }

}