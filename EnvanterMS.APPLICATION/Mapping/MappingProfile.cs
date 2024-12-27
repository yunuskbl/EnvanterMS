using AutoMapper;
using EnvanterMS.APPLICATION.Features.Customer.DTOs;
using EnvanterMS.APPLICATION.Features.Order.DTOs;
using EnvanterMS.APPLICATION.Features.Product.DTOs;
using EnvanterMS.DOMAIN.Entities;

namespace EnvanterMS.APPLICATION.Mapping
{
    public class MappingProfile:Profile 
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Order, OrderDTO>().ReverseMap();
        }
    }
}
