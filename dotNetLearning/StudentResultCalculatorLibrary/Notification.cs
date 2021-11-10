using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StudentResultCalculatorLibrary
{

    public interface INotification
    {
        void Notify(string message, string toaddress);
    }

    public class EmailNotification : INotification
    {
        public void Notify(string message, string toaddress)
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "mailserveraddress";
            smtp.Port = 234;
            MailMessage msg = new MailMessage("abcuni@mail.com", toaddress);
            msg.Subject = "Your result";
            msg.Body = message;
            smtp.Send(msg);
        }
    }
}
