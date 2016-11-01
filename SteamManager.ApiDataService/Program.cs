using System;
using CLAP;

namespace SteamManager.ApiDataService
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Run<ClapInterface>(args);
        }
    }
}
