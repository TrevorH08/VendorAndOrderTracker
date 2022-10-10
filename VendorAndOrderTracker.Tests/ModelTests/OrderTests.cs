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
  }
}