using System;
using System.ComponentModel.DataAnnotations;

namespace MyGarage.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="First name too long")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name too long")]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string PhoneNumber { get; set; }

        [StringLength(1000, ErrorMessage = "Comment too long (max 1000 characters)")]
        public string Comment { get; set; }
        public DateTime? JoinedDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }
    }
}
