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
      Order newOrder = new Order("test","100x Crescent Pastries",85.99);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    { 
      // Arange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      Order newOrder = new Order(orderTitle,"100x Crescent Pastries",85.99);
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
      Order newOrder = new Order(orderTitle,"100x Crescent Pastries",85.99);

      // Act
      string updatedOrderTitle = "Breads for Werewolf bat mitzvah";
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
    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      Order newOrder = new Order(orderTitle,"100x Crescent Pastries",85.99);

      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order () {
      //Arrange
      string orderTitle01 = "Pastries for Werewolf bar mitzvah";
      string orderTitle02 = "Breads for Werewolf bat mitzvah";
      Order newOrder1 = new Order (orderTitle01,"100x Crescent Pastries",85.99);
      Order newOrder2 = new Order (orderTitle02,"150x Maple Bearclaws",95.99);

      //Act
        Order result = Order.Find(2);

      //Assert
      Assert.AreEqual (newOrder2, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    { 
      // Arange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      string orderDescription = "100x Crescent Pastries";
      Order newOrder = new Order(orderTitle,orderDescription,85.99);
      // Act
      string result = newOrder.OrderDescription;
      // Assert
      Assert.AreEqual(orderDescription, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      // Arrange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      string orderDescription = "100x Crescent Pastries";
      Order newOrder = new Order(orderTitle,orderDescription,85.99);

      // Act
      string updatedOrderDescription = "150x Maple Bearclaws";
      newOrder.OrderDescription = updatedOrderDescription;
      string result = newOrder.OrderDescription;

      // Assert
      Assert.AreEqual(updatedOrderDescription, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsPrice_Double()
    { 
      // Arange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      string orderDescription = "100x Crescent Pastries";
      double orderPrice = 85.99;
      Order newOrder = new Order(orderTitle,orderDescription,orderPrice);
      // Act
      double result = newOrder.OrderPrice;
      // Assert
      Assert.AreEqual(orderPrice, result);
    }
    [TestMethod]
    public void SetPrice_SetPrice_Double()
    {
      // Arrange
      string orderTitle = "Pastries for Werewolf bar mitzvah";
      string orderDescription = "100x Crescent Pastries";
      double orderPrice = 85.99;
      Order newOrder = new Order(orderTitle,orderDescription,orderPrice);

      // Act
      double updatedOrderPrice = 95.99;
      newOrder.OrderPrice = updatedOrderPrice;
      double result = newOrder.OrderPrice;

      // Assert
      Assert.AreEqual(updatedOrderPrice, result);
    }
  }
}