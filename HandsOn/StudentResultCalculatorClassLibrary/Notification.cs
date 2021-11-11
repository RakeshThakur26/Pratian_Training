using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultCalculatorClassLibrary
{
    public interface INotification
    {
        void Notify(string message, string address);
    }
    public class EmailNotification : INotification
    {
        public void Notify(string message, string address)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "ServerAddress";
            smtp.Port = 121;
            MailMessage msg = new MailMessage("Admin@mail.com", address);
            msg.Subject = "Your result";
            msg.Body = message;
            smtp.Send(msg);           
        }
    }
}
