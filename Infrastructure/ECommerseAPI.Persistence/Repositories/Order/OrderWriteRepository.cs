using ECommerseAPI.Application.Repositories;
using ECommerseAPI.Domain.Entities;
using ECommerseAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseAPI.Persistence.Repositories;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ECommerseAPIDbContext context) : base(context)
    {
    }
}
