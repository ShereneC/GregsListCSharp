using System;
using System.Collections.Generic;
using GregsListCSharp.Models;

namespace GregsListCSharp.Services
{
  public class CarsService
  {

    internal IEnumerable<Car> GetCars()
    {
      return FakeDB.Cars;
    }

    internal Car GetCarById(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal Car Create(Car newCar)
    {
      FakeDB.Cars.Add(newCar);
      return newCar;
    }


    internal void DeleteCar(string id) {
      int deleted = FakeDB.Cars.RemoveAll(c => c.Id == id);
      if (deleted == 0)
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}