namespace TravelDiary.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public Place(string cityName)
    {
      CityName = "nothing";
    }
  }
}