using Microsoft.EntityFrameworkCore;
using ECommerseAPI.Application.Abstractions;
using ECommerseAPI.Persistence.Concretes;
using ECommerseAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ECommerseAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
          
            services.AddSingleton<IProductService,ProductService>();
            services.AddDbContext<ECommerseAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
