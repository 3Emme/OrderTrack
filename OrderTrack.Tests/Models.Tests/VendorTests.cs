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
      Vendor newVendor = new Vendor("test","A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    { 
      // Arange
      string vendorName = "Wolfman";
      Vendor newVendor = new Vendor(vendorName,"A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.");
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
      Vendor newVendor = new Vendor(vendorName,"A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.");

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
      Vendor newVendor = new Vendor(vendorName,"A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.");

      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor () {
      //Arrange
      string vendorName01 = "Wolfman";
      string vendorName02 = "Count Chocula";
      Vendor newVendor1 = new Vendor (vendorName01,"A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.");
      Vendor newVendor2 = new Vendor (vendorName02,"A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.");

      //Act
        Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual (newVendor2, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    { 
      // Arange
      string vendorName = "Wolfman";
      string vendorDescription = "A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.";
      Vendor newVendor = new Vendor(vendorName,vendorDescription);
      // Act
      string result = newVendor.VendorDescription;
      // Assert
      Assert.AreEqual(vendorDescription, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      // Arrange
      string vendorName = "Wolfman";
      string vendorDescription = "A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.";
      Vendor newVendor = new Vendor(vendorName,vendorDescription);

      // Act
      string updatedVendorDescription = "This description has been redacted.";
      newVendor.VendorDescription = updatedVendorDescription;
      string result = newVendor.VendorDescription;

      // Assert
      Assert.AreEqual(updatedVendorDescription, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      string orderDescription = "100x Crescent Pastries";
      double orderPrice = 85.99;
      string orderDate = "10/21/2020";
      Order newOrder = new Order(orderTitle,orderDescription,orderPrice,orderDate);
      List<Order> newOrderList = new List<Order> { newOrder };
      string vendorName = "Wolfman";
      string vendorDescription = "A furry fellow who once went by the name Jack. He has also been known by the moniker 'Frute Brute'.";
      Vendor newVendor = new Vendor(vendorName,vendorDescription);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.VendorOrders;

      //Assert
      CollectionAssert.AreEqual(newOrderList, result);
    }
  }
}