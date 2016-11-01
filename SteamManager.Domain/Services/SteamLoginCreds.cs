using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamManager.Domain.Model.Steam;

namespace SteamManager.Domain.Services
{
    public class SteamLoginCreds :ISteamLoginCreds
    {
        public LoginCredentialsModel GetLoginCredentials()
        {
            return new LoginCredentialsModel
            {
                Username = "test",
                Password = "test"
            };
        }
    }
}
