using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendApp.Models;

namespace VendApp.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()

    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    { 
      // Arange
      string vendorName = "Wolfman";
      Vendor newVendor = new Vendor(vendorName);
      // Act
      string result = newVendor.VendorName;
      // Assert
      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void SetName_SetName_String()
    {
      // Arrange
      string vendorName = "Wolfman";
      Vendor newVendor = new Vendor(vendorName);

      // Act
      string updatedVendorName = "Count Chocula";
      newVendor.VendorName = updatedVendorName;
      string result = newVendor.VendorName;

      // Assert
      Assert.AreEqual(updatedVendorName, result);
    }
  }
}