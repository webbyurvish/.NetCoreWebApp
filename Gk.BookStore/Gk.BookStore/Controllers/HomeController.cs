using Gk.BookStore.Models;
using Gk.BookStore.Service;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Gk.BookStore.Controllers
{
    [Route("[controller]/[action]")]

    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public HomeController(IConfiguration configuration , IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }
        [Route("/")]
        public ViewResult Index()
        {
            var userId = _userService.GetUserId();
            var isLoggedIn = _userService.IsAuthenticated();
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
