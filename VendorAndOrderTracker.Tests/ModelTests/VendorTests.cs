using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
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
      Vendor newVendor = new Vendor("Test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void Getname_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Vendor Name";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "Trev's Deli";
      string name2 = "Trev's Coffe Shop";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("Test Order", "10/09/22", "This is a test.", 0);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Trev's Deli";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("Trev's Deli");
      Vendor newVendor2 = new Vendor("The Hunter's Deli");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}