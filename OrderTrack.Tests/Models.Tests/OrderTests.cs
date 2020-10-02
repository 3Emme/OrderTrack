using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendApp.Models;

namespace VendApp.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()

    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitile_String()
    { 
      // Arange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      Order newOrder = new Order(orderTitle);
      // Act
      string result = newOrder.OrderTitle;
      // Assert
      Assert.AreEqual(orderTitle, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      // Arrange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      Order newOrder = new Order(orderTitle);

      // Act
      string updatedOrderTitle = "Pastries for Werewolf bat mitzvah";
      newOrder.OrderTitle = updatedOrderTitle;
      string result = newOrder.OrderTitle;

      // Assert
      Assert.AreEqual(updatedOrderTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}