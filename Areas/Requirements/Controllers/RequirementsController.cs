using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loganta.Areas.Requirement.Controllers
{
    public class RequirementsController : Controller
    {
        [Area("Requirements")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
