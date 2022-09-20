﻿using BarberAppDLL.Dto;
using BarberAppDLL.Models.DomainModel;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BarberWebApp.Services
{
    public class BarberService
    {
        public async Task<List<Barber>> Get()
        {
            IEnumerable<Barber> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Barber>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Barber>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

        public async Task<List<Barber>> Search()
        {
            IEnumerable<Barber> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Barber>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Barber>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

        public async Task<List<Barber>> Suggested()
        {
            IEnumerable<Barber> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Barber>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Barber>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

        public async Task<List<Barber>> SortBy()
        {
            IEnumerable<Barber> barbers = null;

            string apiUrl = "https://localhost:44337/api/Barbers";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var apiresponse = new List<Barber>();

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsAsync<List<Barber>>();
                    //var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);
                    apiresponse = data;
                }

                return apiresponse;
            }

        }

        //private readonly string _baseUrl;
        //private readonly IAuthenticationManager _authenticationManager;

        //public BranchService(IOptions<SiteSettings> siteSettings)//, IAuthenticationManager authenticationManager)
        //{
        //    _baseUrl = siteSettings.Value.URL;
        //    //_authenticationManager = authenticationManager;
        //}

        //public async Task<ApiResponse<Barber>> Get(int id)
        //{
        //    var apiResponse = await _baseUrl
        //      .Append("/v1/Barber/Get")
        //      .PostJsonAsync(id)
        //      .ReceiveJson<ApiResponse<Barber>>();

        //    return apiResponse;
        //}
    }
}
