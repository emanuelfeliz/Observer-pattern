using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_6.Models
{
    public class PuestosModels
    {
        public static IEnumerable<PuestosModels> datos = new List<PuestosModels>();
        public string Puesto { get; set; }

        public int Salario { get; set; }

        public string Estatus { set; get; }


        public static PuestosModels Busqueda(string puesto)
        {
            foreach (var item in datos)
            {
                if (item.Puesto == puesto )
                {
                    return item;
                }
            }

            return null;
        }

        


    }
}
