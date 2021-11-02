using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Controllers
{
    public class RepairController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
