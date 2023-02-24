using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Emailsending
{
   public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rn = new Random();
                int otp = rn.Next(1000, 8000);

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("saranyasasi841@gmail.com");

                mail.To.Add("chin929@gmail.com");
                mail.Priority = MailPriority.High;
                mail.Subject = "Test Email";
                mail.Body =otp.ToString();
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("saranyasasi841@gmail.com", "hwyzliqmtdsrgcvu"); // token correct ?
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Send(mail);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Email Send Succesfully");

        }
    }

}
  

