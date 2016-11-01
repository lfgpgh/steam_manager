using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using SteamManager.Client.Model;
using SteamManager.Domain.Services;

namespace SteamManager.Client.Controller
{
    public class SteamController: BaseApiController
    {
        [HttpPost]
        public HttpResponseMessage Login([FromBody]LoginModel model)
        {
            if (!model.ComputerName.Equals(ComputerName))
                throw new UnauthorizedAccessException();

            var steamService = new SteamConsoleService(SteamConsolePath);
            steamService.Login(model.Username,model.Password);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        [HttpPost]
        public HttpResponseMessage Close([FromBody]KillModel model)
        {
            if(!model.ComputerName.Equals(ComputerName))
                throw new UnauthorizedAccessException();

            var steamService = new SteamConsoleService(SteamConsolePath);
            steamService.Close();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage InstallGame([FromBody] string appId)
        {

            return  new HttpResponseMessage(HttpStatusCode.OK);
            //
        }
    }
}
