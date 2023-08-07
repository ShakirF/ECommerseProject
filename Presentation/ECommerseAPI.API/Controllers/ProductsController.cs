﻿
using ECommerseAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerseAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
          await  _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product1", Price = 100, CreatedDate= DateTime.UtcNow, Stock = 10 },
                new() { Id = Guid.NewGuid(), Name = "Product2", Price = 200, CreatedDate= DateTime.UtcNow, Stock = 20 },
                new() { Id = Guid.NewGuid(), Name = "Product3", Price = 300, CreatedDate= DateTime.UtcNow, Stock = 30 },
            });
        var datas =   await _productWriteRepository.SaveAsync();
        }
    }
}
