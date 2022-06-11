using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace PortfolioWebsite.Models
{
    public class EmailSender
    {
        public async Task<bool> SendEmail(string Name, string Email, string Subject, string Message)
        {
            var apiKey = Environment.GetEnvironmentVariable("EmailApiKey");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("sebastianburmancode@gmail.com", "Portfolio Website");
            var subject = Subject;
            var to = new EmailAddress("sebastianjburman@gmail.com", "Myself");
            var plainTextContent = Message;
            var htmlContent = $"<strong>Name: {Name}</strong><br><strong>From: {Email}</strong><br><strong> {Message}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            bool successfulEmail = response.IsSuccessStatusCode;
            return successfulEmail;
        }
    }
}
