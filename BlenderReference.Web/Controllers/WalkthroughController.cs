using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlenderReference.Domain.Data;
using BlenderReference.Domain.Models;
using BlenderReference.Domain.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlenderReference.Web.Controllers
{
    public class WalkthroughController : Controller
    {
        private readonly ILogger<WalkthroughController> _logger;
        private List<WalkthroughModel> WalkthroughScenarios;
        

        // GET: /<controller>/
        public WalkthroughController(ILogger<WalkthroughController> logger)
        {
            _logger = logger;
            WalkthroughScenarios = new List<WalkthroughModel>();
            WalkthroughScenarios = GetWalkthroughItems.GetWalkthroughScenarios();        

        }

        public IActionResult Index(int Id)
        {          
            return View(WalkthroughScenarios);                               
        }

       

    }
}