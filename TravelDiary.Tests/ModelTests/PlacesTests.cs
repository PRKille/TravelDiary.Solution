using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelDiary.Models;
using System;

namespace TravelDiary.Tests
{
  [TestClass]
  public class PlaceTest
  {
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
  }
}