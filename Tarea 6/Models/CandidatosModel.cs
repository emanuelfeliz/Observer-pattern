using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_6.Models.Observer;

namespace Tarea_6.Models
{
    public class CandidatosModel: IObserver
    {
        public static IEnumerable<CandidatosModel> datos = new List<CandidatosModel>();
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int Salario { get; set; }


        public static CandidatosModel Busqueda(string cedula)
        {
            foreach (var item in datos)
            {
                if (item.Cedula == cedula)
                {
                    return item;
                }
            }

            return null;
        }

        public void Observer()
        {
            Console.WriteLine(MailSender.Send(Correo));
        }
    }
}
