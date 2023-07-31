using ECommerseAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseAPI.Persistence
{
    public class DesignTimeDBContextFactory : IDesignTimeDbContextFactory<ECommerseAPIDbContext>
    {
        public ECommerseAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerseAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
