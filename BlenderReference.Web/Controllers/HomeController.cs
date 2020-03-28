using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlenderReference.Web.Models;
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Logic;
using BlenderReference.Domain.Enums;

namespace BlenderReference.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<BlenderQuickReferenceItem> quickRefItems;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            quickRefItems = new List<BlenderQuickReferenceItem>();
            quickRefItems = 
            GetQuickReferenceItems.GetBlenderQuickRefData();
        }

        public IActionResult Index()
        {
            return View(quickRefItems);
        }

        public IActionResult HotKeyReference()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
