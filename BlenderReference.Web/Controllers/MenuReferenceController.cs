using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlenderReference.Web.Models;
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Logic;
using BlenderReference.Domain.Enums;
using BlenderReference.Domain.Data;
using Microsoft.Extensions.Logging;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlenderReference.Web.Controllers
{
    public class MenuReferenceController : Controller
    {
        private readonly ILogger<MenuReferenceController> _logger;
        private List<BlenderMenuReferenceItem> quickMenuItems;
        // GET: /<controller>/
        public MenuReferenceController(ILogger<MenuReferenceController> logger)
        {
            _logger = logger;
            quickMenuItems = new List<BlenderMenuReferenceItem>();
            quickMenuItems = GetMenuReferenceItems.GetBlenderMenuData();
        }

        public IActionResult Index()
        {
            return View(quickMenuItems);
        }
    }
}
