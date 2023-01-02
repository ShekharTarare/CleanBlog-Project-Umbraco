using CleanBlog.Core.Controllers;
using CleanBlog.Core.ViewModels;
using System;
using Umbraco.Core.Logging;

namespace CleanBlog.Core.Services
{
    public class SmtpService : ISmtpService
    {
        private readonly ILogger _logger;
        public SmtpService(ILogger logger)
        {
            _logger = logger;
        }
        public bool SendEmail(ContactViewModel model)
        {
            try
            {
                return true;
                //Umbraco 8 provides logs by default
                //I am not writing the mail code here for now
            }
            catch (Exception ex)
            {
                _logger.Error(typeof(ContactSurfaceController), ex, "Error sending contact form.");
                return false;
            }
        }
    }
}
