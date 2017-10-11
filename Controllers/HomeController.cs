using Microsoft.AspNetCore.Mvc;
using FavPlace.Models;
using System.Collections.Generic;

namespace FavPlace.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/places")]
        public ActionResult Places()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }
        [HttpGet("/places/new")]
        public ActionResult PlaceForm()

        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult AddPlace()
        {
            Place newPlace = new Place(Request.Form["new-placefav"],Request.Form["new-city"], int.Parse(Request.Form["new-stay"]));
            List<Place> allPlaces = Place.GetAll();
            return View("Places", allPlaces);
        }

        [HttpGet("/places/{id}")]
        public ActionResult PlaceDetails(int id)
        {
            Place place = Place.Find(id);
            return View(place);
        }

        [HttpPost("/place/list/clear")]
         public ActionResult PlaceListClear()
         {
             Place.ClearAll();
             return View();
         }

  }
}
