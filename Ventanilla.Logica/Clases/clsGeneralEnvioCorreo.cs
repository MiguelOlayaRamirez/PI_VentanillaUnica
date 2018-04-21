using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Clases
{
    public class clsGeneralEnvioCorreo
    {
        public void setEmail(Modelo.clsEmail obclsEmail)
        {
            try
            {
                //Objeto del Correo
                MailMessage Mail = new MailMessage();

                Mail.From = new MailAddress(obclsEmail.stFrom);
                Mail.To.Add(obclsEmail.stTo);
                Mail.Subject = obclsEmail.stAsunto;
                Mail.Body = obclsEmail.stMensaje;

                if (obclsEmail.inTipo == 0) Mail.IsBodyHtml = false;
                else if (obclsEmail.inTipo == 1) Mail.IsBodyHtml = true;

                if (obclsEmail.inPrioridad == 2) Mail.Priority = MailPriority.High;
                else if (obclsEmail.inPrioridad == 1) Mail.Priority = MailPriority.Low;
                else if (obclsEmail.inPrioridad == 0) Mail.Priority = MailPriority.Normal;

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(obclsEmail.stMensaje, Encoding.UTF8, MediaTypeNames.Text.Html);

                //Incrustando una Imagen * Una sola imagen sin son más imágenes se crean más lineas de Mail.AlternativeViews.Add(htmlView);
                LinkedResource img = new LinkedResource(obclsEmail.stImagen, MediaTypeNames.Image.Jpeg);
                img.ContentId = obclsEmail.stIdImagen;
                htmlView.LinkedResources.Add(img);

                Mail.AlternateViews.Add(htmlView);

                //Cliente de servidor de correo
                SmtpClient smtp = new SmtpClient();
                smtp.Host = obclsEmail.stServidor;

                if (obclsEmail.blAutenticacion) smtp.Credentials = new System.Net.NetworkCredential(obclsEmail.stusuario, obclsEmail.stPassword);
                if (obclsEmail.stPuerto.Length > 0) smtp.Port = Convert.ToInt32(obclsEmail.stPuerto);

                smtp.EnableSsl = obclsEmail.blConexionSegura;
                smtp.Send(Mail);

            }
            catch (Exception ex) { throw ex; }
        }
    }
}
