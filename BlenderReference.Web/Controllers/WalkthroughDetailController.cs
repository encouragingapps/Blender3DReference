using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlenderReference.Domain.Logic;
using BlenderReference.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlenderReference.Web.Controllers
{
    public class WalkthroughDetailController : Controller
    {
        private List<WalkthroughModel> WalkthroughDetail;
    
        public IActionResult Index(int Id)
        {
            WalkthroughDetail = new List<WalkthroughModel>();
            WalkthroughDetail = GetWalkthroughItems.GetWalkthroughDetail(Id);

            ViewBag.WalkthroughTitle = 
            WalkthroughDetail.Select(x => x.WalkthroughName).First().ToString();

            return View(WalkthroughDetail);
        }
    }
}