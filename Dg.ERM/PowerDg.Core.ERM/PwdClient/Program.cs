using IdentityModel.Client;
using System;
using System.Net.Http;

namespace PwdClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            #region TokenEndpoint
            var diso = DiscoveryClient.GetAsync("http://localhost:5000").Result;
            if (diso.IsError)
            {
                Console.WriteLine(diso.Error);
            }
            var tokenClient = new TokenClient(diso.TokenEndpoint,
                "pwdClient", "secret");
            //var 
            var tokenResponse = tokenClient
                .RequestResourceOwnerPasswordAsync("jesse", "123455").Result;
                //.RequestClientCredentialsAsync("api").Result;
            if (tokenResponse.IsError)
            {
                Console.WriteLine(tokenResponse.Error);
            }
            else
            {
                Console.WriteLine(tokenResponse.Json);
            }

            #endregion


            //HttpClientDeviceFlowExtensions
            var httpClient = new HttpClient();

            //携带Token
            httpClient.SetBearerToken(tokenResponse.AccessToken);

            var response = httpClient.GetAsync("http://localhost:5001/api/values").Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            }


            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
