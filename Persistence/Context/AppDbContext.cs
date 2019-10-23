using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Persistence.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Domain.Item> Items { get; set; }
        public DbSet<Domain.Identity> Identities { get; set; }

       
    }
}
