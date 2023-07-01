using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nyanlearnDotNet.Library.Email
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
