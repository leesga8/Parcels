using System.Collections.Generic;

namespace Parcel.Models
{
  public class Item
  {
    public static int Length { get; set; }
    public static int Width { get; set; }
    public static int Height { get; set; }
    public static int Weight { get; set; }
  
    public Item (int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;

    }
        public static int Volume()
    {
      int volume = Length*Width*Height;
      return volume;
    }

    public static int CostToShip()
    {
      int cost = Length*Width*Height + Weight;
      return cost;
    }

  }
}
