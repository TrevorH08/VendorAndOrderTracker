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

    
  }
}