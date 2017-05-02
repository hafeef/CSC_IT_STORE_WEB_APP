using Microsoft.AspNet.Identity;
using System.Configuration;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CSC.Core.Common.Services
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            var fromEmailAdderss = ConfigurationManager.AppSettings["FromEmailAdderss"].ToString();
            MailMessage mailMessage = new MailMessage(fromEmailAdderss, message.Destination, message.Subject, message.Body);
            SmtpClient client = new SmtpClient()
            {
                UseDefaultCredentials = true
            };
            return client.SendMailAsync(mailMessage);
        }
    }
}
