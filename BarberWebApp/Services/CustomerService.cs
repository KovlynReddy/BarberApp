using BarberAppDLL.Models.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BarberWebApp.Services
{
    public class CustomerService
    {

        public async Task<List<Customer>> Get()
        {
            IEnumerable<Customer> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Customer>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Customer>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

    }
}
