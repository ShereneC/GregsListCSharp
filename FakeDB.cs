using System.Collections.Generic;
using GregsListCSharp.Models;

namespace GregsListCSharp
{
  static public class FakeDB
  {
    static public List<Car> Cars { get; set; } = new List<Car>() { new Car("Honda", "Accord", 1986, 1000, "https://images.unsplash.com/photo-1592908689142-f9d2d4f5d23d?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1091&q=80", "It's a great car!" )};

  static public List<House> Houses { get; set; } = new List<House>() {
    new House(2000, 3, 1, 2, 300000, "https://images.unsplash.com/photo-1583608205776-bfd35f0d9f83?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80", "A very, very very fine house")};
  }

  }