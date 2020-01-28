using RestSharp;
using System;

namespace WorkDayTokenExtractionExample
{
    class Program
    {
        static void Main(string[] args)
        {


            var client = new RestClient("https://login.microsoftonline.com/623ec005-a3d1-4dd8-901b-66199f855166/oauth2/v2.0/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", "grant_type=client_credentials&client_id=INPUT CLIENTID HERE&client_secret=INPUT CLIENTSECRET HERE&scope=INPUT SCOPE HERE", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            Console.WriteLine(response.Content);

            Console.ReadKey();
        }
    }
}
