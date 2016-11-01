using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SteamManager.Domain.Services;

namespace SteamManager.Domain.Test
{
    [TestClass]
    public class SteamUserServiceTest
    {
        [TestMethod]
        public void GetOwnedGamesTest()
        {
            var apiKey = "";
            var apiUser = new SteamUserService(apiKey);
            var steamid = "76561197960434622";//"STEAM_0:1:40776493"
            apiUser.GetOwnedGames(steamid);
            //U:1:81552987

        }

        [TestMethod]
        public void GetGameInfo()
        {
            var steamStoreService = new SteamStoreService();
            steamStoreService.GetGameInfo("289070");
        }
    }
}
