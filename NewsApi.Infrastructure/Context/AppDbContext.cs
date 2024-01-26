using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Infrastructure.Context
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions options) : base (options) { }

        
    }
}
