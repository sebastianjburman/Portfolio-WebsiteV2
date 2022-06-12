using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PortfolioWebsite.Models
{
    public class EmailSender
    {
         HttpClient client = new HttpClient();
        public async Task<bool> SendEmail(string Name, string Email, string Subject, string Message)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://portfoliowebsiteapisendgrid.azurewebsites.net/api/Email/send");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Name", Name);
            request.Headers.Add("Email", Email);
            request.Headers.Add("Subject", Subject);
            request.Headers.Add("Message", Message);

            var response = await client.SendAsync(request);

            bool successfulEmail = response.IsSuccessStatusCode;
            return successfulEmail;
        }
    }
}
