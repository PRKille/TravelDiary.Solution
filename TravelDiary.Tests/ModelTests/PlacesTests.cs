using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelDiary.Models;
using System;

namespace TravelDiary.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      // Arrange
      string cityName = "Istanbul";

      // Act
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;

      // Assert
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      // Arrange
      List<Place> newPlaces = new List<Place> {};

      // Act
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(newPlaces, result);
    }
  }
}