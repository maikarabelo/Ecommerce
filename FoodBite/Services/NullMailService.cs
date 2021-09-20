using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBite.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;
        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string to, int phone, string body)
        {
            //log the message
            _logger.LogInformation($"To: {to} Phone: {phone} Body: {body}");
        }
    }
}
