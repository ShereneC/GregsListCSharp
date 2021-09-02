using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GregsListCSharp.Models;
using GregsListCSharp.Services;

namespace GregsListCSharp.Controllers
{
  [ApiController]
  [Route("api/[controller]")]

  public class CarsController : ControllerBase
  {

    private readonly CarsService _carsService;

    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
          IEnumerable<Car> cars = _carsService.GetCars();
          return Ok(cars);
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);

      }
    }

    [HttpGet("{id}")]
    public ActionResult<Car> Get(string id)
    {
      try
      {
         Car found = _carsService.GetCarById(id);
         return Ok(found); 
      }
      catch (Exception err)
      {
          return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
          Car car = _carsService.Create(newCar);
          return Ok(car);
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
          _carsService.DeleteCar(id);
          return Ok("Car has been purchased and removed from DB");
      }
      catch (Exception err)
      {
return BadRequest(err.Message);
      }
    }
  }
}