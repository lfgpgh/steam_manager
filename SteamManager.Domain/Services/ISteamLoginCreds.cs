using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamManager.Domain.Model.Steam;

namespace SteamManager.Domain.Services
{
    public interface ISteamLoginCreds
    {
        LoginCredentialsModel GetLoginCredentials();
    }
}
