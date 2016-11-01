using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Owin;

namespace SteamManager.Client
{
    public class Startup
    {

        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();
            config.Services.Replace(typeof(IExceptionHandler), new ExceptionHandler());
            config.Routes.MapHttpRoute(
                name: "Ping",
                routeTemplate: "ping",
                defaults: new {Controller = "Ping", Action = "Index" }
            );
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new {}
            );

            appBuilder.UseWebApi(config);
        }
    }

    public class ExceptionHandler : IExceptionHandler
    {
        public virtual Task HandleAsync(ExceptionHandlerContext context,
            CancellationToken cancellationToken)
        {
            Console.WriteLine(context.Exception.ToString());
            return Task.FromResult(0);
        }

    }
}
