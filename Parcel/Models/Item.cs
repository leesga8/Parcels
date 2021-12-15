using System.Collections.Generic;

namespace Parcel.Models
{
  public class Item
  {
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
  
    public Item (int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;

      _instances.Add(this);
    }
    public int Volume()
    {
      int volume = Length*Width*Height;
      return volume;
    }

    public int CostToShip()
    {
      int cost = Length*Width*Height + Weight;
      return cost;
    }

    private static List<Item> _instances = new List<Item> { };

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
