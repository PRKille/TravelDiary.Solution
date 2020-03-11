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
      Place newPlace = new Place("Istanbul");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}