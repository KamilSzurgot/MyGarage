using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Shared
{
    public class CustomerModel
    {
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Neigborhood { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";

        public DateTime Dob { get; set; } = new DateTime(1999, 1, 1);
    }
}
