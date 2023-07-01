using nyanlearnDotNet.Library.Email;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string message)
    {
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential("nyanlearn2023@gmail.com", "jdozcrydlwyhpjsn")
        };

        return client.SendMailAsync(
            new MailMessage(from: "nyanlearn2023@gmail.com",
                            to: email,
                            subject,
                            message
                            ));
    }


}