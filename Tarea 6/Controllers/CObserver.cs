using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_6.Models;

namespace Tarea_6.Controllers
{
    public class CObserver : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Suscribir()
        {
            ViewData["v"] = PuestosModels.datos.Where(e => e.Estatus.Equals("vacante")); 
            return View();
        }
    }
}
