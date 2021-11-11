using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Tarea_6.Models;
using System.Collections.Generic;
using System.Linq;


namespace Tarea_6.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();

        }

        public IActionResult Candidatos()
        {

            return View();
        }


        
        [HttpPost]
        public IActionResult PuestoGuardado(PuestosModels mol)
        {
            List<PuestosModels> list = PuestosModels.datos.ToList();
            list.Add(mol);
            PuestosModels.datos = list;

            return View(PuestosModels.datos);
        }

        [HttpGet]
        public IActionResult PuestoGuardado()
        {
            List<PuestosModels> list = PuestosModels.datos.ToList();
          

            return View(PuestosModels.datos);
        }


        public IActionResult Puestos()
        {
            //var Puesto = from e in GetPuestos()
            //             orderby e.Puesto
            //             select e;
            return View();
        }


        //public List<PuestosModels> GetPuestos()
        //{
        //    return new List<PuestosModels>
        //    {
        //    new PuestosModels
        //    {
        //        Puesto = "Ingeniero civil",
        //        Salario = 90000,
        //        Estatus = "ocupado"
        //    },
        //    new PuestosModels
        //    {
        //        Puesto = "Desarrollador De Software",
        //        Salario = 80000,
        //        Estatus = "vacante"
        //    },
        //    new PuestosModels
        //    {
        //        Puesto = "Diseñador grafico",
        //        Salario = 10000,
        //        Estatus = "vacante"
        //    },
        //    new PuestosModels
        //    {
        //        Puesto = "DBA",
        //        Salario = 50000,
        //        Estatus = "ocupado"
        //    },
        //    };
        //}


        [HttpPost]
        public IActionResult EditarPuesto(PuestosModels mol)
        {
            PuestosModels puest = PuestosModels.datos.ToList().Find(g => g.Puesto.Equals(mol.Puesto));
            if (puest != null)
            {
                puest.Salario = mol.Salario;
                puest.Estatus = mol.Estatus;
            }

            return RedirectToAction("PuestoGuardado", PuestosModels.datos);
        }

        [HttpGet]
        public IActionResult EditarPuesto(string puesto)
        {
            PuestosModels puest = PuestosModels.datos.ToList().Find(g => g.Puesto.Equals(puesto));

            return View(puest);
        }

        public IActionResult Privacy()
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
