using Microsoft.AspNetCore.Mvc;
using TravelDiary.Models;
using System.Collections.Generic;
using System;

namespace TravelDiary.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string duration, string description, string travelPartner, string imageURL)
    {
      if (String.IsNullOrWhiteSpace(imageURL))
      {
        Place newPlace = new Place(cityName, duration, description, travelPartner);
      }
      else
      {
        Place newPlace = new Place(cityName, duration, description, travelPartner, imageURL);
      }
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

    [HttpPost("/places/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }

    [HttpPost("/places/{id}")]
    public ActionResult Update(string cityName, string duration, string description, string travelPartner, string imageURL, int id)
    {
      Place foundPlace = Place.Find(id);
      if (String.IsNullOrWhiteSpace(imageURL))
      {
        foundPlace.CityName = cityName;
        foundPlace.Duration = duration;
        foundPlace.Description = description;
        foundPlace.TravelPartner = travelPartner;
      }
      else
      {
        foundPlace.CityName = cityName;
        foundPlace.Duration = duration;
        foundPlace.Description = description;
        foundPlace.TravelPartner = travelPartner;
        foundPlace.ImageURL = imageURL;
      }
      return RedirectToAction("Index");
    }

  }
}