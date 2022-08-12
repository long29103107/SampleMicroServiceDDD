using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OrderingShop.Domain.Dtos;
using OrderingShop.Infrastructure.Context.Entities;

namespace OrderingShop.Domain.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
