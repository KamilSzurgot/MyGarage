using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Shared
{
    public class Repair
    {
        public int RepairId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Name too long")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Comment { get; set; }

        [Required]
        public string CarInfo { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public bool IsFinished { get; set; }
    }
}
