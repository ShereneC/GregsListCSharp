using System;
using System.Collections.Generic;
using GregsListCSharp.Models;

namespace GregsListCSharp.Services
{
  public class HousesService
  {

    internal IEnumerable<House> GetHouses()
    {
      return FakeDB.Houses;
    }

    internal House GetHouseById(string id)
    {
      House found = FakeDB.Houses.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }

    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }


    internal void DeleteHouse(string id) {
      int deleted = FakeDB.Houses.RemoveAll(c => c.Id == id);
      if (deleted == 0)
      {
        throw new Exception("Invalid Id");
      }
    }
  }
}