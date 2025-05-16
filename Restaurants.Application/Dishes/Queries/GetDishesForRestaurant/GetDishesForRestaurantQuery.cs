using MediatR;
using Restaurants.Application.Restaurants.Dtos;

namespace Restaurants.Application.Dishes.Queries.GetDishesForRestaurant
{
    public class GetDishesForRestaurantQuery(int restaurantId) : IRequest<IEnumerable<DishDto>>
    {
        public int RestaurantId { get; } = restaurantId;
    }
}
