using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamManager.Domain.Model.Json
{
    public class GetOwnedGames
    {
        public Response response { get; set; }
    }
    public class Response
    {
        public int game_count { get; set; }
        public Game[] games { get; set; }
    }

    public class Game
    {
        public int appId { get; set; }
        public int playtime_forever { get; set; }
    }
}
