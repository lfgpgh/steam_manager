using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Domain.Services
{
    public interface ISteamStoreService
    {
        void GetGameInfo(string appId);
    }
}
