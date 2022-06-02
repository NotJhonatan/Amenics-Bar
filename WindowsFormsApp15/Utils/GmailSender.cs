using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15.Utils
{
    class GmailSender
    {
        public void Enviar(string emailPara, string codigo)
        {
            Task.Factory.StartNew(() =>
            {
                System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();

                string remetente = "octantis.tech@gmail.com";
                string senhaRemetente = "8technology!";

                email.From = new System.Net.Mail.MailAddress(remetente);
                email.To.Add(emailPara);

                email.Subject = "Recuperar Conta";
                email.Body = "Seu código de verificação é: " + "'" + codigo + "'.";
                email.IsBodyHtml = true;

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(remetente, senhaRemetente);

                smtp.Send(email);

            });
        }
    }
}
