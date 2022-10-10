using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title1 = "Test";
      string title2 = "NotTest";
      string date1 = "10/09/22";
      string date2 = "12/24/22";
      string description1 = "Tiny Order";
      string description2 = "Massive Order";
      int price1 = 40;
      int price2 = 40000;
      Order newOrder1 = new Order(title1, date1, description1, price1);
      Order newOrder2 = new Order(title2, date2, description2, price2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "10/10/22", "test order", 500);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescrtiption_ReturnsDescription_String()
    {
      string description = "Really big order.";
      Order newOrder = new Order("test", "10/10/22", description, 500);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Really big order.";
      Order newOrder = new Order("test", "10/10/22", description, 500);
      
      string updatedDescription = "Very small order.";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "test";
      Order newOrder = new Order(title, "10/09/22", "Very small order.", 500);
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Really big order.";
      Order newOrder = new Order(title, "10/09/22", "Very small order.", 500);
      
      string updatedTitle = "Very small order.";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "10/09/22";
      Order newOrder = new Order("test", date, "Very small order.", 500);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string date = "10/09/22";
      Order newOrder = new Order("test", date, "Very small order.", 500);
      
      string updatedDate = "10/10/22";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;

      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 500;
      Order newOrder = new Order("test", "10/10/22",  "Very small order.", price);
      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      int price = 500;
      Order newOrder = new Order("test", "10/10/22", "Very small order.", price);
      
      int updatedPrice = 1000;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }


  }
}