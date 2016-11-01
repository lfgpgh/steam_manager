using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Domain.Services
{
    public interface ISteamConsoleService
    {
        void Login(string username, string password);
        void Close();
    }
}
