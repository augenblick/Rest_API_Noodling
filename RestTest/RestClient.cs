using System;
using System.Net.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RestTest
{
    public enum httpVerb
    {
        GET,
        POST
    }
    class RestClient
    {
        public static readonly HttpClient comClient = new HttpClient();
        public string restURI { get; set; }
        public httpVerb actionType { get; set; }

        public RestClient(){
        
            restURI = string.Empty;
            actionType = httpVerb.GET;
            
        }

        public async Task<string> makeRequest()
        {
            if (string.IsNullOrEmpty(this.restURI))
            {
                throw new System.ArgumentException("Please enter a REST API URI.");
            }

            string stringResponse = string.Empty;

                HttpResponseMessage restResponse = await comClient.GetAsync(requestUri: restURI).ConfigureAwait(continueOnCapturedContext: false);
                Debug.WriteLine($"Rest Response: {restResponse.Content}");
                restResponse.EnsureSuccessStatusCode();
                stringResponse = await restResponse.Content.ReadAsStringAsync();
                stringResponse = Regex.Replace(stringResponse, @"\r\n?|\n", System.Environment.NewLine);

            return stringResponse;
        }
    }
}
