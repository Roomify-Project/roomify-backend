﻿namespace Roomify.GP.Core.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);
    }
}
