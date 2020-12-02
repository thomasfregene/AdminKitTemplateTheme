using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminKitTemplateTheme.Controllers
{
    public class UI_ElementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
