using NHLapp.Models.NHL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NHLapp.Data
{
    public class NhlContext: DbContext // This class is used as entry for EF
    {
        public NhlContext(): base("DefaultConnection")
        {}

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

    }
}