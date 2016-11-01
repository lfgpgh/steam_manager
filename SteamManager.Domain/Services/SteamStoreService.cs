using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using SteamManager.Domain.Model.Json;

namespace SteamManager.Domain.Services
{
    public class SteamStoreService : ISteamStoreService
    {

        private string _baseUrl;

        public SteamStoreService()
        {
            _baseUrl = "http://store.steampowered.com/";
        }
        public void GetGameInfo(string appId)
        {
            var url = $"{_baseUrl}api/appdetails?appids={appId}";
            using (var client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 5, 0);
                client.DefaultRequestHeaders.ConnectionClose = true;
                var response = client.GetStringAsync(url).Result;
                var gameInfo = JsonConvert.DeserializeObject<Dictionary<string,SteamGameInfo>>(response);
            }
        }
    }
}
