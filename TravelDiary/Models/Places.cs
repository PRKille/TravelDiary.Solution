using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; } 
    public string Duration { get; set; }
    public string Description { get; set; }
    public string TravelPartner { get; set; }
    public string ImageURL { get; set; }
    public int Id { get; }

    public Place(string cityName, string duration, string description, string travelPartner)
    {
      CityName = cityName;
      Duration = duration;
      Description = description;
      TravelPartner = travelPartner;
    }

    public Place(string cityName, string duration, string description, string travelPartner, int id)
      : this(cityName, duration, description, travelPartner)
    {
      Id = id;
    }

    public Place(string cityName, string duration, string description, string travelPartner, int id, string imageURL)
      : this(cityName, duration, description, travelPartner, id)
    {
      ImageURL = imageURL;
    }

    public static List<Place> GetAll()
    {
      List<Place> allPlaces = new List<Place> {};
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM places;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        int placeID = rdr.GetInt32(4);
        string cityName = rdr.GetString(0);
        string duration = rdr.GetString(1);
        string description = rdr.GetString(2);
        string travelPartner = rdr.GetString(3);
        Place newPlace = new Place(cityName, duration, description, travelPartner, placeID);
        allPlaces.Add(newPlace);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allPlaces;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM places;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      
    }

    public static Place Find(int searchId)
    {
      Place placeholderPlace = new Place("cityName", "1 month", "something", "geoff's mom");
      return placeholderPlace;
    }
  }
}