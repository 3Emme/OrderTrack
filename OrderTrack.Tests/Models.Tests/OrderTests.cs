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
    { //Arange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      Order newOrder = new Order(orderTitle);
      //Act
      string result = newOrder.OrderTitle;
      //Assert
      Assert.AreEqual(orderTitle, result);
    }
  }
}