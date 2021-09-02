using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GregsListCSharp.Models;
using GregsListCSharp.Services;

namespace GregsListCSharp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class HousesController : ControllerBase
  {
    private readonly HousesService _hs;

    public HousesController(HousesService hs)
    {
      _hs = hs;
    }

    [HttpGet]
    public ActionResult<IEnumerable<House>> Get()
    {
       try
       {
           IEnumerable<House> houses = _hs.GetHouses();
           return Ok(houses);
       }
       catch (Exception err)
       {
           return BadRequest(err.Message);
       }
    }


    [HttpGet("{id}")]
    public ActionResult<House> Get(string id)
    {
      try
      {
         House found = _hs.GetHouseById(id);
         return Ok(found); 
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);
      }
    }

        [HttpPost]
    public ActionResult<House> Create([FromBody] House newHouse)
    {
      try
      {
          House house = _hs.Create(newHouse);
          return Ok(house);
      }
      catch (Exception err)
      {
return BadRequest(err.Message);
      }
    }

       [HttpDelete("{id}")]
    public ActionResult<String> Delete(string id)
    {
      try
      {
          _hs.DeleteHouse(id);
          return Ok("House has been purchased and removed from DB");
      }
      catch (Exception err)
      {
return BadRequest(err.Message);
      }
    } 
  }
}