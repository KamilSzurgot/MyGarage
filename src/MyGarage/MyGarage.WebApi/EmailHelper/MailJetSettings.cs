using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.EmailHelper
{
    public class MailJetSettings
    {
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string Email { get; set; }
    }
}
