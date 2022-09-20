using BarberAppDLL.Dto;
using BarberAppDLL.Models.DomainModel;
using BarberAppDLL.Models.Dto;
using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Newtryx.Services
{
    public class BookingService
    {
        public async Task<List<LogVisit>> Get()
        {
            IEnumerable<LogVisit> bookings = null;


            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<LogVisit>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<LogVisit>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                    //Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                }

                return apiresponse;
            }

        }

        public async Task<List<LogVisit>> CreateBooking()
        {
            IEnumerable<LogVisit> bookings = null;


            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<LogVisit>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<LogVisit>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                    //Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                }

                return apiresponse;
            }

        }

        public async Task<List<LogVisit>> CancelBooking()
        {
            IEnumerable<LogVisit> bookings = null;


            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<LogVisit>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<LogVisit>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                    //Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                }

                return apiresponse;
            }

        }

        public async Task<List<LogVisit>> EditBooking()
        {
            IEnumerable<LogVisit> bookings = null;


            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<LogVisit>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<LogVisit>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                    //Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                }

                return apiresponse;
            }

        }

    }
}
        //private readonly string _baseUrl;
        //private readonly IAuthenticationManager _authenticationManager;

        //public BookingService(IOptions<SiteSettings> siteSettings, IAuthenticationManager authenticationManager)
        //{
        //    _authenticationManager = authenticationManager;
        //    _baseUrl = siteSettings.Value.URL;
        //}

        //public async Task<ApiResponse> Create(BookingDto reservation)
        //{
        //    return await _baseUrl.WithHeader("X-TENANT-ID", _authenticationManager.GetTenant()).AppendPathSegment("/v1/Booking/").WithOAuthBearerToken(await _authenticationManager.GetToken()).PostJsonAsync(reservation).ReceiveJson<ApiResponse>();
        //}

        //public async Task<ApiResponse> Update(BookingDto reservation)
        //{
        //    return await _baseUrl.WithHeader("X-TENANT-ID", _authenticationManager.GetTenant()).AppendPathSegment("/v1/Booking/").WithOAuthBearerToken(await _authenticationManager.GetToken()).PutJsonAsync(reservation).ReceiveJson<ApiResponse>();
        //}

        //public async Task<ApiResponse> UpdateOld(BookingDto reservation)
        //{
        //    return await _baseUrl.WithHeader("X-TENANT-ID", _authenticationManager.GetTenant()).AppendPathSegment("/v1/Booking/").WithOAuthBearerToken(await _authenticationManager.GetToken()).PutJsonAsync(reservation).ReceiveJson<ApiResponse>();
        //}

        //public async Task<ApiResponse> Get(int id)
        //{
        //    return await _baseUrl.WithHeader("X-TENANT-ID", AppendPathSegments("/v1/Booking/").AppendPathSegment(id).WithOAuthBearerToken(await _authenticationManager.GetToken()).GetJsonAsync<ApiResponse>();
        //}


        //}
        //}


