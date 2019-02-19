using System.Collections.Generic;

namespace Dealership.Models 
{
  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private static List<Car> list = new List<Car>() {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      list.Add(this);
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      MakeModel = newMakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public void SetMiles(int newMiles)
    {
      Miles = newMiles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }

    public static List<Car> GetList()
    {
      return list;
    }
  }

}