using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title  { get; set; }
    public string Date { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>

    public Order(string title, , string date, string description, int price)
    {
      Title = title;
      Date = date;
      Description = description;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}