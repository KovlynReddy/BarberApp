using BarberAppDLL.Models.DomainModel;
using BarberAppDLL.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BarberWebApp.Services
{
    public class AddressService
    {

        public async Task<List<Address>> Get()
        {
            IEnumerable<Address> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Address>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Address>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

        public async Task<List<Address>> GetAll()
        {
            IEnumerable<Address> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers/GetAll";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Address>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Address>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

        public async Task<List<Address>> FindClosest()
        {
            IEnumerable<Address> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Address>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Address>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }


        public async Task<CreateAddressDto> LinkAddress((string,string) newLink)
        {
            IEnumerable<CreateBarberDto> Addresses = null;

            string apiUrl = "https://localhost:44337/api/Address/LinkDto";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var newbarberJson = Newtonsoft.Json.JsonConvert.SerializeObject(newAddress);
                var payload = new StringContent(newbarberJson, Encoding.UTF8, "application/json");

                HttpResponseMessage result = await client.PostAsync(apiUrl, payload);

                //result.EnsureSuccessStatusCode();

                var apiresponse = new List<CreateAddressDto>();

                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsAsync<List<CreateAddressDto>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

            public async Task<List<CreateAddressDto>> Create(CreateAddressDto newAddress)
        {
            IEnumerable<CreateBarberDto> Addresses = null;

            string apiUrl = "https://localhost:44337/api/Address/CreateDto";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var newbarberJson = Newtonsoft.Json.JsonConvert.SerializeObject(newAddress);
                var payload = new StringContent(newbarberJson, Encoding.UTF8, "application/json");

                HttpResponseMessage result = await client.PostAsync(apiUrl, payload);

                //result.EnsureSuccessStatusCode();

                var apiresponse = new List<CreateAddressDto>();

                if (result.IsSuccessStatusCode)
                {
                    var data = await result.Content.ReadAsAsync<List<CreateAddressDto>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }


    }
}
