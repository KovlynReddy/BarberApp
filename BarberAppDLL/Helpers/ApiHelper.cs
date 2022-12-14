using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace BarberAppDLL.Helpers
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; } 

        public static void InitializeClient() {

            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://localhost:44337/api/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        
        }
    }
}
