using System;
using System.ComponentModel.DataAnnotations;

namespace QMS.core.Models
{
    public class VendorMasterViewModel
    {
        public int VendorID { get; set; }

        [Required(ErrorMessage = "Vendor name is required")]
        [StringLength(200)]
        public string VendorName { get; set; }

        [StringLength(500)]
        public string? Address { get; set; }

        [StringLength(100)]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }

        [StringLength(15)]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string? MobileNumber { get; set; }

        [StringLength(20)]
        public string? GSTNumber { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string? CreatedBy { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
