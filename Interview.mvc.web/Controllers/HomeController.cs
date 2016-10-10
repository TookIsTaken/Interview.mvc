using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Interview.Domain.Contracts;
using Interview.Data.Model;
using Interview.mvc.web.Models;

namespace Interview.mvc.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            var homeModel = new UserTableViewModel(){
                Users = _userService.GetAllUsers()
            };

            return View(homeModel);
        }
    }
}