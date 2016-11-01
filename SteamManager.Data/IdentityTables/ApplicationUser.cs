using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SteamManager.Data.IdentityTables
{
    public class ApplicationUser :IdentityUser<Guid,ApplicationUserLogin,ApplicationUserRole,ApplicationUserClaim>, IRequired
    {
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
    }
}
