using AutoMapper;
using Restaurants.Domain.Entities;

namespace Restaurants.Application.Restaurants.Dtos
{
    public class DishProfile : Profile
    {
        public DishProfile() 
        {
            CreateMap<Dish, DishDto>();
        }
    }
}
