using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLAP;
using SteamManager.ApiDataService.Operations;

namespace SteamManager.ApiDataService
{
    public class ClapInterface
    {
        #region [Operations]
        [Verb]
        public static void PullSteamAccountInfo()
        {
            new PullSteamAccountInfo().Apply();
        }
        #endregion

        #region [CLI Defaults]
        /// <summary>
        /// Global error handler
        /// </summary>
        /// <param name="context">The exception that occured</param>
        [Error]
        public static void HandleError(ExceptionContext context)
        {
            Console.WriteLine(context.Exception.Message);
            Console.WriteLine(context.Exception.StackTrace);
            context.ReThrow = true;
        }

        /// <summary>
        /// this is an empty handler that prints
        /// the automatic help string to the console.
        /// </summary>
        /// <param name="help"></param>
        [Empty, Help]
        public static void Help(string help)
        {
            Console.WriteLine(help);
        }
        #endregion
    }
}
