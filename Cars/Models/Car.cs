using System;
using System.Collections.Generic;

namespace Cars.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price ;
    private int _miles;
    private bool _saved;
    private string _color;
    private static List<Car> _carList = new List<Car>(){};

    public Car(string makeModel, int price, int miles, string color = "Blue")
    {
      _saved = false;
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _color = color;
    }

    public Car()
    {
      _saved = false;
      _makeModel = "Civic";
      _price = 15000;
      _miles = 0;
      _color = "Silver";
    }

    public static List<Car> GetCars()
    {
      return _carList;
    }

    public void Save()
    {
      if(!_saved)
      {
        _carList.Add(this);
      }
      _saved = true;
    }

    public void SetModel(string makeModel)
    {
      _makeModel = makeModel;
    }

    public string GetModel()
    {
      return _makeModel;
    }

    public void SetPrice(int price)
    {
      _price = price;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int miles)
    {
      _miles = miles;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetColor(string color)
    {
      _color = color;
    }

    public string GetColor()
    {
      return _color;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_price < maxPrice && _miles < maxMiles);
    }

    public void CarInfo()
    {
      Console.WriteLine("Model: "+_makeModel);
      Console.WriteLine("Price: "+_price.ToString());
      Console.WriteLine("Miles: "+_miles.ToString());
      Console.WriteLine("Color: "+_color);
    }
  }
}
  // public class Program
  // {
  //   public static void Main()
  //   {
  //     Car porsche = new Car("2014 Porsche 911",114991,7864);
  //     Car ford = new Car("2011 Ford F450",55995,14241,"Black");
  //     Car lexus = new Car("2013 Lexus RX 350",44700,20000,"Red");
  //     Car mercedes = new Car("Mercedes Benz CLS550",39900,37979,"Green");
  //
  //     List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
  //     List<Car> MatchingCars = new List<Car>(0);
  //
  //     Console.WriteLine("Enter Maximum Price:");
  //     int maxPrice = int.Parse(Console.ReadLine());
  //     Console.WriteLine("Enter Maximum Mileage:");
  //     int maxMiles = int.Parse(Console.ReadLine());
  //
  //     foreach(Car automobile in Cars)
  //     {
  //       if(automobile.WorthBuying(maxPrice,maxMiles))
  //       {
  //         MatchingCars.Add(automobile);
  //       }
  //     }
  //
  //     if(MatchingCars.Count != 0)
  //     {
  //       foreach(Car automobile in MatchingCars)
  //       {
  //         automobile.CarInfo();
  //       }
  //     }
  //     else
  //     {
  //       Console.WriteLine("No Cars Found");
  //     }
  //
  //   }
  // }
