using System;
using System.ComponentModel.DataAnnotations;
using QMS.core.DatabaseContext;
using System.ComponentModel.DataAnnotations.Schema;
namespace QMS.core.Models
{
    

    public class CertificateMasterViewModel
    {
        [Key]
        public int CertificateID { get; set; }

        [StringLength(50)]
        public string? CertificateName { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [StringLength(50)]
        // Consider VARCHAR(255) for FileUploadPath in DB
        public string? FileUploadPath { get; set; }

        public DateTime? CreatedDate { get; set; }

        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }

}
