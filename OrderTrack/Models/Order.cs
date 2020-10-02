using System.Collections.Generic;

namespace VendApp.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string title)
    {
      Title = title;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}