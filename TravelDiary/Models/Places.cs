using System.Collections.Generic;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Description { get; set; }
    public string TravelPartner { get; set; }
    public string ImageURL { get; set; }
    public int Id { get; }
    private static List<Place> _allPlaces { get; } = new List<Place> {};

    public Place(string cityName, string description, string travelPartner)
    {
      CityName = cityName;
      Description = description;
      TravelPartner = travelPartner;
      _allPlaces.Add(this);
      Id = _allPlaces.Count;
    }

    public Place(string cityName, string description, string travelPartner, string imageURL)
      : this(cityName, description, travelPartner)
    {
      ImageURL = imageURL;
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