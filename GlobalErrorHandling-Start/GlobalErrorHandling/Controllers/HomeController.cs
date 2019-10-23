using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace globalerrorhandling.Controllers
{
    public class HomeController : Controller
    {
        ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            this.logger.LogDebug("Index was called");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}