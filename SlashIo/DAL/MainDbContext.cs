using Microsoft.AspNet.Identity.EntityFramework;
using SlashIo.Models;
using System.Data.Entity;


namespace SlashIo.DAL
{
    public class MainDbContext : IdentityDbContext<AppUser>
    {
        public MainDbContext() : base("SlashIoDatabaseCS")
        {

        }

        public DbSet<OgPropertySet> OgPropertySets { get; set; }
        public DbSet<PageDetails> PageDetails { get; set; }
    }
}