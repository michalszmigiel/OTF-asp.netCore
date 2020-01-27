using OTF.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OTF.Data
{
  public interface IRestaurantData
  {
    IEnumerable<Restaurant> GetRestaurantsByName(string name);
    Restaurant GetById(int id);
  }
  public class InMemoryRestaurantData : IRestaurantData
  {
    List<Restaurant> restaurants;
    public InMemoryRestaurantData()
    {
      restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name="Michq's Pizza Place", Location="Lodz", Cuisine=CuisineType.Italian},
                new Restaurant {Id = 2, Name="TARARARA Place", Location="Lodz", Cuisine=CuisineType.Mexican},
                new Restaurant {Id = 3, Name="WAH PAH's Indian Place", Location="Lodz", Cuisine=CuisineType.Indian}
            };
    }
    public Restaurant GetById(int id)
    {
      return restaurants.SingleOrDefault(r => r.Id == id);
    }
    public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
    {
      return from r in restaurants
             where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
             orderby r.Name
             select r;
    }
  }
}
