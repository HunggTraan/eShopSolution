﻿using eShopSolution.Utilities.Constants;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Services
{
    public class BaseApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        protected BaseApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        protected async Task<TResponse> GetAsync<TResponse>(string url)
        {
            var sessions = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppSettings.Token);
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppSettings.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
            var response = await client.GetAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TResponse myDeserializedObjList = (TResponse)JsonConvert.DeserializeObject(body, typeof(TResponse));
                return myDeserializedObjList;
            }
            return JsonConvert.DeserializeObject<TResponse>(body);
        }
    }
}