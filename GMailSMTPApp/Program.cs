using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace GMailSMTPApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            String to, subject, body;

            Console.WriteLine("Enter Email Address of Receiver");
            to = Console.ReadLine();
            Console.WriteLine("Enter Subject of Email");
            subject = Console.ReadLine();
            Console.WriteLine("Enter Body of Email");
            body = Console.ReadLine();

            using(MailMessage mailMessage = new MailMessage(ConfigurationManager.AppSettings["FromEmail"], to))
            {
                SmtpClient smtpClient;
                NetworkCredential credential;

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = false;

                credential = new NetworkCredential();
                credential.UserName = ConfigurationManager.AppSettings["Username"];
                credential.Password = ConfigurationManager.AppSettings["Password"];

                smtpClient = new SmtpClient();
                smtpClient.Host = ConfigurationManager.AppSettings["Host"];
                smtpClient.Port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = credential;

                Console.Write("Sending Email........\n");
                smtpClient.Send(mailMessage);
            }
        }
    }
}
