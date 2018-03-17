using SlashIo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SlashIo.DAL
{
    public class OgPropertySetContext : DbContext
    {
        public OgPropertySetContext() : base("SlashIoDatabaseCS")
        {

        }

        public DbSet<OgPropertySet> Clients { get; set; }
    }
}