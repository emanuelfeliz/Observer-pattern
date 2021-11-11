using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Tarea_6.Models
{
    public class MailSender
    {
        public static string Send(string correo)
        {
            MailMessage mm = new MailMessage("emanuel.felizmendez@gmail.com", correo);
            mm.Subject = "vacante disponible";
            mm.Body = "";
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smt.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("emanuel.felizmendez@gmail.com", "gmailpassword");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            string msj = "Mensaje enviado";

            return (msj);
        }
    }
}
