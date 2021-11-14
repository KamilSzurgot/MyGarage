using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vonage.Request;
using Vonage.Messaging;
using Microsoft.Extensions.Configuration;

namespace MyGarage.WebApi.EmailHelper
{
    public class SmsService
    {
        public IConfiguration Configuration { get; set; }
        public SmsService(IConfiguration config)
        {
            Configuration = config;
        }

        public SendSmsResponse SendSms(string to, string from, string text)
        {
            var apiKey = "62c2ba68";
            var apiSecret = "dQ45JqlPMMkW3n69";
            var creds = Credentials.FromApiKeyAndSecret(apiKey, apiSecret);
            var client = new SmsClient(creds);
            var request = new SendSmsRequest
            {
                To = to,
                From = from,
                Text = text
            };
            return client.SendAnSms(request);
        }
    }
}
