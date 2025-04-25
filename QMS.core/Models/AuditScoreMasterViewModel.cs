using System;
using System.ComponentModel.DataAnnotations;
using QMS.core.DatabaseContext;
using System.ComponentModel.DataAnnotations.Schema;
namespace QMS.core.Models
{
    public class AuditScoreMasterViewModel
    {
        [Key]
        public int AuditID { get; set; }

        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [StringLength(50)]
        public string? Year { get; set; }

        [StringLength(50)]
        public string? Score { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }

   
}
