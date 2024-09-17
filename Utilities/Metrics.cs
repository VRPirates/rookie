using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AndroidSideloader.Utilities
{
    internal class Metrics
    {
        public static async void CountDownload(string packageName, string versionCode)
        {
            try
            {
                var apiUrl = "https://api.vrpirates.wiki/metrics/add";

                var requestBody = new
                {
                    packagename = packageName,
                    versioncode = versionCode
                };
                var json = JsonConvert.SerializeObject(requestBody);
                string res = await Task.Run(() => sendToApi(apiUrl, json, "post"));
                _ = Logger.Log(res);
            }
            catch (Exception ex)
            {
                Logger.Log($"Unable to log download: {ex.Message}", LogLevel.WARNING);
            }
        }


        private static async Task<string> sendToApi(string apiUrl, string requestBody = null, string type = "get")
        {
            string token = "cm9va2llOkN0UHlyTE9oUGoxWXg1cE9KdDNBSkswZ25n";

            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage();

                // Set the HTTP method
                request.Method = type.ToLower() == "post" ? HttpMethod.Post : HttpMethod.Get;

                // For GET requests with parameters, append them to the URL
                if (request.Method == HttpMethod.Get && !string.IsNullOrEmpty(requestBody))
                {
                    var uriBuilder = new UriBuilder(apiUrl);
                    uriBuilder.Query = requestBody;
                    request.RequestUri = uriBuilder.Uri;
                }
                else
                {
                    request.RequestUri = new Uri(apiUrl);
                }

                // For POST requests, set the content
                if (request.Method == HttpMethod.Post && !string.IsNullOrEmpty(requestBody))
                {
                    request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                }

                // Add headers to the request
                request.Headers.Add("Authorization", token);
                request.Headers.Add("Origin", "rookie");

                string responseContent = "";
                try
                {
                    HttpResponseMessage response = await client.SendAsync(request);
                    responseContent = await response.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    Logger.Log($"Unable to get Metrics Data: {ex.Message}", LogLevel.WARNING);
                }

                return responseContent;
            }
        }
    }
}