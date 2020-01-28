using Microsoft.EntityFrameworkCore;
using OTF.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTF.Data
{
    public class OTFDbContext : DbContext
    {
        public OTFDbContext(DbContextOptions<OTFDbContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
