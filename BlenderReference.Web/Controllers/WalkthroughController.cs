using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlenderReference.Web.Controllers
{
    public class WalkthroughController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}