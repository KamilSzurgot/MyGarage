using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Linq;
using System.Threading.Tasks;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Options;

namespace MyGarage.WebApi.EmailHelper
{
    public class EmailSender : IEmailSender
    {
        private readonly MailJetSettings _mailJetSettings;
        public EmailSender(IOptions<MailJetSettings> mailJetSettings)
        {
            _mailJetSettings = mailJetSettings.Value;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient(_mailJetSettings.PublicKey, _mailJetSettings.PrivateKey);
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
                new JObject {
                    {
                        "From",
                         new JObject {
                            {"Email", _mailJetSettings.Email},
                            {"Name", "Kamil"}
                         }
                    }, {
                        "To",
                         new JArray {
                            new JObject {
                                {
                                    "Email",
                                    email
                                }, {
                                    "Name",
                                    "Hello"
                                 }
                            }
                         }
                    }, {
                        "Subject",
                        subject
                    }, {
                        "HTMLPart",
                        htmlMessage
                    }, {
                        "CustomID",
                        "AppGettingStartedTest"
                    }
                }
             });
            MailjetResponse response = await client.PostAsync(request);
        }
    }
}
