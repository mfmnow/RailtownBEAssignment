using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Waitiing for Web Application to load...");
            Thread.Sleep(5000);
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44319/api/user/get-closest-users");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic parsedJson = JsonConvert.DeserializeObject(responseBody);
            Console.WriteLine(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));
        }
    }
}
