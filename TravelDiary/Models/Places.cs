using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; }
    private static List<Place> _allPlaces { get; } = new List<Place> {};

    public Place(string cityName)
    {
      CityName = cityName;
      _allPlaces.Add(this);
    }

    public static List<Place> GetAll()
    {
      return _allPlaces;
    }

    public static void ClearAll()
    {
      _allPlaces.Clear();
    }
  }
}