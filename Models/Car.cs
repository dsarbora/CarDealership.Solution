using System;

namespace Dealership {

  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
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
  }

}