using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_6.Models;

namespace Tarea_6.Controllers
{
    public class CController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditarCandidato(CandidatosModel mol)
        {
            CandidatosModel puest = CandidatosModel.datos.ToList().Find(g => g.Cedula.Equals(mol.Cedula));
            if (puest != null)
            {
                puest.Correo = mol.Correo;
                puest.Salario = mol.Salario;
                   
            }

            return RedirectToAction("AccionCandidatos");
        }

        [HttpGet]
        public IActionResult EditarCandidato(string Cedula)
        {
            CandidatosModel candidatos1 = CandidatosModel.datos.ToList().Find(g => g.Cedula.Equals(Cedula));

            return View(candidatos1);
        }




        [HttpPost]
        public IActionResult AccionCandidatos(CandidatosModel mol)
        {
            List<CandidatosModel> list = CandidatosModel.datos.ToList();
            list.Add(mol);
            CandidatosModel.datos = list;

            return View(CandidatosModel.datos);

        }

        [HttpGet]
        public IActionResult AccionCandidatos()
        {
            List<CandidatosModel> list = CandidatosModel.datos.ToList();


            return View(CandidatosModel.datos);

        }

        public IActionResult Candidatos()
        {
            return View();
        }
    }
}
