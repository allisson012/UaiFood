using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UaiFood.Controller
{
    internal class EmailSender
    {
        private string remetente = "uaifood.sup@gmail.com";
        private string senha = "mscz awou btyv ytjj";

        public bool EnviarEmail(string destinatario, string codigoRecuperacao)
        {
            try
            {

                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress(remetente);
                mensagem.To.Add(destinatario);
                mensagem.Subject = "Recuperação de Conta";
                mensagem.Body = $"Olá! Aqui está seu código de recuperação: {codigoRecuperacao}";
                mensagem.IsBodyHtml = false;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(remetente, senha);
                smtp.EnableSsl = true;

                smtp.Send(mensagem);

                return true;
            }
            catch (SmtpException ex)
            {
                // Você pode exibir a mensagem de erro ou logar
                MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
                return false;
            }
        }
    }
}
