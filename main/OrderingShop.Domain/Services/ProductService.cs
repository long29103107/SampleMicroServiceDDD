using AutoMapper;
using OrderingShop.Domain.Dtos;
using OrderingShop.Domain.Interfaces;
using OrderingShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingShop.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var result = await _productRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(result);
        }
    }
}
