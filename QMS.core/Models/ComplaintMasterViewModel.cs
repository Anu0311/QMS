using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QMS.core.Models
{
    
    public class ComplaintMasterViewModel
    {
        [Key]
        public int ComplaintID { get; set; }

        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [StringLength(50)]
        public string? ComplaintNumber { get; set; }

        [StringLength(50)]
        public string? ComplaintType { get; set; }

        [StringLength(150)]
        // Consider VARCHAR(500) or TEXT for ComplaintDescription
        public string? ComplaintDescription { get; set; }

        [StringLength(50)]
        public string? Category { get; set; }

        [StringLength(50)]
        public string? ProductType { get; set; }

        [StringLength(50)]
        public string? RootCause { get; set; }

        [StringLength(50)]
        public string? CorrectiveAction { get; set; }

        [StringLength(50)]
        public string? Rating { get; set; }

        public bool? Status { get; set; }

        public DateTime? ClosureDate { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }

   
}
