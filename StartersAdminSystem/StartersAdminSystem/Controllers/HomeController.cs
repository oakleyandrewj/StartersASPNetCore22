using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StartersAdminSystem.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StartersAdminSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStarterRepository _StarterRepository;

        public HomeController(IStarterRepository starterRepository)
        {
            _StarterRepository = starterRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
