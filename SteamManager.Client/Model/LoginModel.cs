using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Client.Model
{
    public class LoginModel:IAuthToken
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ComputerName { get; set; }
    }
}
