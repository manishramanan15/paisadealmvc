using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Biztek.Paisadeal.App.Web.Infrastructure
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}