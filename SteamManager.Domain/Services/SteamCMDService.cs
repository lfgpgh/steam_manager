using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Domain.Services
{
    public class SteamCMDService : ISteamCMDService
    {
        private string _cmdPath;

        public SteamCMDService(string cmdPath)
        {
            _cmdPath = cmdPath;
        }

        public void InstallGame(string appId)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = string.Format("{0}\\steamcmd.exe", _cmdPath),
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = string.Format(@"+ login steamcmd + login < username > < password > +force_install_dir c:\KFServer\ +app_update 215350 + quit < username > < password > +force_install_dir c:\KFServer\ +app_update 215350 + quit")
            };
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.Start();
            }
            //steamcmd + login steamcmd + login < username > < password > +force_install_dir c:\KFServer\ +app_update 215350 + quit < username > < password > +force_install_dir c:\KFServer\ +app_update 215350 + quit
        }
    }
}
