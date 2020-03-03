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


            string stringResponse = string.Empty;
            try
            {
                // HttpClient comClient = new HttpClient();
                HttpResponseMessage restResponse = await comClient.GetAsync(requestUri: restURI).ConfigureAwait(continueOnCapturedContext: false);
                Debug.WriteLine(restResponse.Content);
                restResponse.EnsureSuccessStatusCode();
                stringResponse = await restResponse.Content.ReadAsStringAsync();
            }
            catch (Exception e)
            {
                stringResponse = $"{e.Message}{System.Environment.NewLine}{e.StackTrace}";
            }
            stringResponse = Regex.Replace(stringResponse, @"\r\n?|\n", System.Environment.NewLine);
            Debug.WriteLine(stringResponse);
            return stringResponse;

        }

    }
}
