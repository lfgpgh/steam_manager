using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SteamManager.Data.IdentityTables
{
    public class ApplicationUserRole : IdentityUserRole<Guid>, IRequired
    {
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }
    }
}
