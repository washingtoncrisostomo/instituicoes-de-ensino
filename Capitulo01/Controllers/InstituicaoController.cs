using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01.Controllers
{
    public class InstituicaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
