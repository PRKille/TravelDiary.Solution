using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Place
  {
    public string Description { get; set; }
    public string CityName { get; }
    public int Id { get; }
    private static List<Place> _allPlaces { get; } = new List<Place> {};

    public Place(string cityName, string description)
    {
      CityName = cityName;
      Description = description;
      _allPlaces.Add(this);
      Id = _allPlaces.Count;
    }

    public static List<Place> GetAll()
    {
      return _allPlaces;
    }

    public static void ClearAll()
    {
      _allPlaces.Clear();
    }

    public static Place Find(int searchId)
    {
      return _allPlaces[searchId - 1];
    }
  }
}