using System.Collections.Generic;

namespace VendApp.Models
{
  public class Vendor
  {
    public string VendorName { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}