using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;namespace SpecFlowProjectUIAndAPI.Helpers;

public static class RestAPIHelper
{        public static string? ApiResponse { get; set; }

        public static async Task CallRESTWebAPI(string url, string? queryData = null)
        {
            UriBuilder fullUri = new UriBuilder(url);
            if (!string.IsNullOrEmpty(queryData))
                fullUri.Query = queryData;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //GET Method                
                HttpResponseMessage response = await client.GetAsync(fullUri.Uri);
                if (response.IsSuccessStatusCode)
                {
                    ApiResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"RestAPI response message from API EndPointis: {ApiResponse}");
                }
                else
                {
                    Console.WriteLine($"Internal server Error while calling GET REST Web API end point {fullUri.Uri}");
                }
            }
        }
        public static string? GetRESTApiResponse(string url, string? queryData = null)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url + queryData);
            request.Method = "GET";
            using HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode.Equals(HttpStatusCode.OK))
            {
                using Stream responseStream = response.GetResponseStream();
                using StreamReader myStreamReader = new StreamReader(responseStream, Encoding.UTF8);
                string responseJSON = myStreamReader.ReadToEnd();
                Console.WriteLine($"RestAPI response message from API EndPointis: {responseJSON}");
                return responseJSON;
            }
            else
            {
                Console.WriteLine($"Error while calling API - {url + queryData}");
                return null;
            }
        }
    }

    
