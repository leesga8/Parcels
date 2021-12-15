using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
       public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
      // return View();
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Item myItem = new Item(length, width, height, weight);
      return RedirectToAction("Index");
    }


  }
}