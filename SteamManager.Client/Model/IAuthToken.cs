using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Client.Model
{
    public interface IAuthToken
    {
        string ComputerName { get; set; }
    }
}
