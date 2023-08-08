using ECommerseAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerseAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
