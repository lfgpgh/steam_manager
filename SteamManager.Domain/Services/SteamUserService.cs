using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using SteamManager.Domain.Model.Json;

namespace SteamManager.Domain.Services
{
    public class SteamUserService: ISteamUserService
    {
        private string _apiKey;
        private string _baseUrl;
        public SteamUserService(string apiKey)
        {
            _apiKey = apiKey;
            _baseUrl = "http://api.steampowered.com/";
        }

        public void GetOwnedGames(string userId)
        {
            var url = $"{_baseUrl}IPlayerService/GetOwnedGames/v0001/?key={_apiKey}&steamid={userId}&format=json";
            using (var client = new HttpClient())
            {
                client.Timeout = new TimeSpan(0, 5, 0);
                client.DefaultRequestHeaders.ConnectionClose = true;
                var response = client.GetStringAsync(url).Result;
                var ownedGames =
                       JsonConvert.DeserializeObject<GetOwnedGames>(response);

                var steamStoreService = new SteamStoreService();
                foreach (var responseGame in ownedGames.response.games)
                {
                    steamStoreService.GetGameInfo(responseGame.appId.ToString());
                }

            }
        }


    }
}
