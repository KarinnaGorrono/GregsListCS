using GregsListCS.DB;

namespace GregsListCS
{
    public class CarsService
    {
        internal List<Car> Get()
        {
            return FakeDB.Cars;
        }

        internal Car Get(string id)
        {
            Car found = FakeDB.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid ID");
            }
            return found;
        }
        internal Car Create(Car newCar)
        {
            FakeDB.Cars.Add(newCar);
            return newCar;
        }
        internal Car Edit(Car editedCar)
        {
            Car oldCar = Get(editedCar.Id);
            oldCar.Make = editedCar.Make != null ? editedCar.Make : oldCar.Make;
            oldCar.Model = editedCar.Model != null ? editedCar.Model : oldCar.Model;
            oldCar.Year = editedCar.Year != 0 ? editedCar.Year : oldCar.Year;
            oldCar.Price = editedCar.Price != 0 ? editedCar.Price : oldCar.Price;
            oldCar.Color = editedCar.Color != null ? editedCar.Color : oldCar.Color;
            return oldCar;
        }
        internal void Remove(string id)
        {
            Car car = Get(id);
            FakeDB.Cars.Remove(car);
        }
    }
}