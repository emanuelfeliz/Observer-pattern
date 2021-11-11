using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Tarea_6.Models
{
    public class Datos
    {
        private static string pathMain = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private static string downloadPath = Path.Combine(pathMain, "Downloads\\log.txt");

        public bool GenerateTxt(CandidatosModel puestos)
        {
            string body = $"<Cedula:{puestos.Cedula}\n Nombre: {puestos.Nombre}\n Correo: {puestos.Correo}\n Salario: {puestos.Salario}>\n";

            using (StreamWriter writer = new StreamWriter(downloadPath, true))
            {
                writer.WriteLine(body);
            }

            return File.Exists(downloadPath);

        }

        public IEnumerable<CandidatosModel> GetList()
        {
            IEnumerable<CandidatosModel> list = null;

            try
            {
                if (File.Exists(downloadPath))
                {

                    using (StreamReader sr = new StreamReader(downloadPath))
                    {
                        Regex get = new Regex(": \\w+");

                        for (int i = 0; i < 4; i++)
                        {
                            CandidatosModel modl = new CandidatosModel();

                            modl.Cedula = get.Match(sr.ReadLine()).Value;
                            modl.Nombre = get.Match(sr.ReadLine()).Value;
                            modl.Correo = get.Match(sr.ReadLine()).Value;
                            modl.Salario = int.Parse(get.Match(sr.ReadLine()).Value);
                            list.Append(modl);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                GenerateTxt(null);
            }

            return list;
        }
    }
}
