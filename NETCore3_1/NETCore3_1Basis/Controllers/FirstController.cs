using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NETCore3_1Basis.Controllers
{
    public class FirstController : Controller
    {
        private readonly ILogger<FirstController> _logger;

        public FirstController(ILogger<FirstController> logger)
        {
            Console.WriteLine("this is log");
            _logger = logger;
            logger.LogInformation("this is loginfo");
        }
        public IActionResult Index()
        {
            base.TempData["u1"] = "this is u1";
            base.ViewBag.u2 = "this is u2";
            base.HttpContext.Session.SetString("u3", "this is u3");
            ViewData["u4"] = "this is u4";
            object data = "this is data";
            return View(data);
        }
    }
}
