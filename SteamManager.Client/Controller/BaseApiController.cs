using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using SteamManager.Core.Utilities;

namespace SteamManager.Client.Controller
{
    public class BaseApiController:ApiController
    {
        private static string _salt = "kD8V3b0NA94";
        public string ComputerName => HashHelper.SHA256Hash(Environment.MachineName, _salt);

        public string SteamConsolePath => ConfigurationManager.AppSettings["SteamConsolePath"];
    }
}
