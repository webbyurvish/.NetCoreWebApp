using Gk.BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Gk.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = 123;
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "Nitish";
            ViewBag.Data = data;
            ViewBag.Type = new BookModel() { Id = 5, Author = "This is author" };

            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
          return View();
        }
    }
}
