using System.Collections.Generic;

namespace VendApp.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; }
    public Order(string orderTitle)
    {
      OrderTitle = orderTitle;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}