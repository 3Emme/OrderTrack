using System.Collections.Generic;

namespace VendApp.Models
{
  public class Vendor
  {
    public string VendorTitle { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };
    public Vendor(string vendorTitle)
    {
      VendorTitle = vendorTitle;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}