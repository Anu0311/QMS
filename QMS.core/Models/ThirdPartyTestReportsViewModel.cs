using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QMS.core.DatabaseContext;
namespace QMS.core.Models
{
    
    public class ThirdPartyTestReportsViewModel
    {
        [Key]
        public int TestID { get; set; }

        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [StringLength(50)]
        public string? TestName { get; set; }

        [StringLength(50)]
        // Consider VARCHAR(255) for UploadPath
        public string? UploadPath { get; set; }

        public DateTime? ReportDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }

   
}
