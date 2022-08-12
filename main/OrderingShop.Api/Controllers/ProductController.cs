﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderingShop.Domain.Dtos;
using OrderingShop.Domain.Interfaces;

namespace OrderingShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger
            , IProductService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("GetAllProducts")]
        [ProducesResponseType(typeof(IEnumerable<ProductDto>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var result = await _service.GetAllProductsAsync();

            if (result.Any()) return Ok(result);

            _logger.LogInformation("Products not found");
            return NotFound("Products not found");
        }
    }
}
