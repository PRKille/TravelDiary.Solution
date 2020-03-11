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
      Place newPlace = new Place("test", "test", "test");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      // Arrange
      string cityName = "Istanbul";

      // Act
      Place newPlace = new Place(cityName, "test", "test");
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

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      // Arrange
      string cityName1 = "Istanbul";
      string cityName2 = "Berlin";
      Place newPlace1 = new Place(cityName1, "test", "test");
      Place newPlace2 = new Place(cityName2, "test", "test");
      List<Place> allPlaces = new List<Place> { newPlace1, newPlace2 };

      // Act
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(allPlaces, result);
    }

    [TestMethod]
    public void GetId_PlacesInstantiateWithAnIdAndGetterReturns_Int()
    {
      // Arrange
      string cityName = "Vienna";
      Place newPlace = new Place(cityName, "test", "test");

      // Act
      int result = newPlace.Id;

      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectPlace_Place()
    {
      // Arrange
      string cityName1 = "Istanbul";
      string cityName2 = "Berlin";
      Place newPlace1 = new Place(cityName1, "test", "test");
      Place newPlace2 = new Place(cityName2, "test", "test");

      // Act
      Place result = Place.Find(2);

      // Assert
      Assert.AreEqual(newPlace2, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      //Arrange
      string cityName = "Vienna";
      string description = "This is a test";
      Place newPlace = new Place(cityName, description, "test");

      //Act
      string result = newPlace.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetTravelPartner_ReturnTravelPartner_String()
    {
      //Arrange
      string cityName = "Vienna";
      string travelPartner = "Michelle";
      Place newPlace = new Place(cityName, "test", travelPartner);

      //Act
      string result = newPlace.TravelPartner;

      //Assert
      Assert.AreEqual(travelPartner, result);
    }
  }
}