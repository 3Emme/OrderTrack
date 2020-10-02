using System.Collections.Generic;

namespace VendApp.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public Order(string title)
    {
      OrderTitle = title;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}