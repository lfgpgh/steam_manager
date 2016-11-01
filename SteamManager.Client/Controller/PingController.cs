using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SteamManager.Client.Controller
{
    public class PingController: ApiController
    {
        [HttpGet]
        public bool Index()
        {
            return true;
        }
    }
}
