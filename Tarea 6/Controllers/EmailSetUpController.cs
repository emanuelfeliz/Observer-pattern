using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_6.Models;
using System.Net;
using System.Net.Mail;

namespace Tarea_6.Controllers
{
    public class EmailSetUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suscribir(Gmail model)
        {
            foreach (var item in CandidatosModel.datos)
            {
                
            }
            return RedirectToAction("Suscribir");
        }


    }
}
