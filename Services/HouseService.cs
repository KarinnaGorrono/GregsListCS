
using GregsListCS.DB;

namespace GregsListCS
{
  public class HousesService
  {
    internal List<House> Get()
    {
      return FakeDB.Houses;
    }
    internal House Get(string id)
    {
      House found = FakeDB.Houses.Find(h => h.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid ID");
      }
      return found;
    }
    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }
    internal House Edit(House editedHouse)
    {
      House oldHouse = Get(editedHouse.Id);
      
      oldHouse.Bathrooms = editedHouse.Bathrooms != 0 ? editedHouse.Bathrooms : oldHouse.Bathrooms;
      oldHouse.Bedrooms = editedHouse.Bedrooms != 0 ? editedHouse.Bedrooms : oldHouse.Bedrooms;
      oldHouse.Levels = editedHouse.Levels != 0 ? editedHouse.Levels : oldHouse.Levels;
      oldHouse.Price = editedHouse.Price != 0 ? editedHouse.Price : oldHouse.Price;
    
      return oldHouse;
    }
    internal void Remove(string id)
    {
      House house = Get(id);
      FakeDB.Houses.Remove(house);
    }
  }
}