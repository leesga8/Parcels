using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Item starterItem = new Item(1,1,1,1);
      return View(starterItem);
    }

    [Route("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [Route("/items")]
    public ActionResult Create(int length, int width, int height, int weight)
    {
      Item myItem = new Item(length, width, height, weight);
      return View("Index", myItem);
    }


  }
}