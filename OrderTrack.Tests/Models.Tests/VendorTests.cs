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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Vendor> newList = new List<Vendor> { };

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_VendorInstantiateWithAnIdAndGetterReturns_Int()
    {
      string vendorName = "Wolfman";
      Vendor newVendor = new Vendor(vendorName);

      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor () {
      //Arrange
      string vendorName01 = "Wolfman";
      string vendorName02 = "Count Chocula";
      Vendor newVendor1 = new Vendor (vendorName01);
      Vendor newVendor2 = new Vendor (vendorName02);

      //Act
        Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual (newVendor2, result);
    }
  }
}