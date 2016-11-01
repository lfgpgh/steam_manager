using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using SteamManager.Data.IdentityTables;

namespace SteamManager.Data
{
    public class SteamManagerContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>, ISteamManagerContext
    {
        public SteamManagerContext() : this("DefaultConnection")
        {
            Database.CommandTimeout = 180;
        }
        
        public SteamManagerContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public override int SaveChanges()
        {
            UpdateRequiredFields();
            return base.SaveChanges();
        }

        private void UpdateRequiredFields()
        {

            DateTime now = DateTime.UtcNow;
            var a = ChangeTracker.Entries();
            ChangeTracker.Entries().Where(o => o.Entity is IRequired)
                .Select(o => o.Cast<IRequired>()).ToList()
                .ForEach(o => UpdateRequiredFieldsFor(o.Entity, now, o.State));
        }

        private void UpdateRequiredFieldsFor(IRequired required, DateTime now, EntityState state)
        {
            if (state == EntityState.Added)
            {
                required.CreatedOn = now;
            }

            if (state == EntityState.Added || state == EntityState.Modified)
            {
                required.UpdatedOn = now;
            }
        }
    }
}
