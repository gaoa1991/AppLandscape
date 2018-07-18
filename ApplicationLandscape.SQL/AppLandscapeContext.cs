using Microsoft.EntityFrameworkCore;
using System;

namespace ApplicationLandscape.SQL
{
    public class AppLandscapeContext:DbContext
    {
        public AppLandscapeContext(DbContextOptions<AppLandscapeContext> options) : base(options)
        {

        }

        public DbSet<Entity> EntityTbl { get; set; }
        public DbSet<Archer> AncherTbl { get; set; }
        public DbSet<Vendor> VendorTbl { get; set; }
        public DbSet<Relationship> RelationshipTbl { get; set; }
        public DbSet<Hardware> HardwareTbl { get; set; }
        public DbSet<IPAddress> IPAddressTbl { get; set; }

    }
}
