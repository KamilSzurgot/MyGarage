﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Shared
{
    public class GeneratePDFCommand
    {
        public CustomerModel Customer { get; set; }
        public InvoiceModel Invoice { get; set; }
    }
}
