using QMS.core.DatabaseContext.Shared;
using QMS.core.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_CertificateMaster")]
    public class CertificateMaster : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("CertificateID")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        // Note: IsDeleted column does not exist in tbl_CertificateMaster
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("CertificateName")]
        [StringLength(50)]
        public string? CertificateName { get; set; }

        [Column("IssueDate")]
        public DateTime? IssueDate { get; set; }

        [Column("ExpiryDate")]
        public DateTime? ExpiryDate { get; set; }

        [Column("FileUploadPath")]
        [StringLength(50)]
        // Consider VARCHAR(255) for FileUploadPath in DB
        public string? FileUploadPath { get; set; }

        [Column("CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        [Column("VendorID")]
        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }
}