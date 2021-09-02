using System;
using System.ComponentModel.DataAnnotations;

namespace GregsListCSharp.Models
{

  public class Car
  {

    public string Id { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(20)]

    public string Make { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(20)]

    public string Model { get; set; }

    [Required]
    [Range(1950, 2022)]
    public int Year { get; set; }

    [Range(1, 500000)]
    public int Price { get; set; }

    public string ImgUrl { get; set; }

    public string Description { get; set; }



    public Car(string make, string model, int year, int price, string imgUrl, string description)
    {
      Make = make;
      Model = model;
      Year = year;
      Price = price;
      ImgUrl = imgUrl;
      Description = description;
      Id = Guid.NewGuid().ToString();
    }
  }
}