using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WonderAPI.Model
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ClienteContext> cliente { get; set; }
    }
}
