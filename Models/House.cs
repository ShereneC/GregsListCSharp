using System;
using System.ComponentModel.DataAnnotations;

namespace GregsListCSharp.Models
{
  public class House
  {

        [Required]
            [Range(1900, 2022)]
    public int Year {get; set;}

                [Range(1, 10)]
    public int Bedrooms {get; set;}

                [Range(1, 10)]
    public int Levels {get; set;}

                [Range(1, 10)]
    public int Bathrooms {get; set;}

    [Required]
    public int Price {get; set;}


    public string ImgUrl {get; set;}
    public string Description {get; set;}

    public string Id {get; set;}
      public House(int year, int bedrooms, int levels, int bathrooms, int price, string imgUrl, string description)
    {
      Year = year;
      Bedrooms = bedrooms;
      Levels = levels;
      Bathrooms = bathrooms;
      Price = price;
      ImgUrl = imgUrl;
      Description = description;
      Id = Guid.NewGuid().ToString();
    }
  }
}