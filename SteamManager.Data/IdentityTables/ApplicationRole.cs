using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SteamManager.Data.IdentityTables
{
    public class ApplicationRole : IdentityRole<Guid, ApplicationUserRole>, IRequired
    {
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
    }
}
