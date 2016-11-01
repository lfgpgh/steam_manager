using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Domain.Services
{
    public class SteamConsoleService : ISteamConsoleService
    {
        private readonly string _consolePath;
        public SteamConsoleService(string consolePath)
        {
            _consolePath = consolePath;

        }

        public void Login(string username, string password)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName = string.Format("{0}\\steam.exe", _consolePath),
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = string.Format("-login {0} {1}", username, password)
            };
            
            using (Process exeProcess = Process.Start(startInfo))
            {
                exeProcess.Start();
            }
        }

        public void Close()
        {
            var steam = Process.GetProcessesByName("Steam");
            foreach (var process in steam)
            {
                process.Kill();
            }
        }
    }
}
