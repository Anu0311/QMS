using QMS.core.DatabaseContext.Shared;
using QMS.core.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_PDIMaster")]
    public class PDIMaster : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("PDI_ID")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        // Note: IsDeleted column does not exist in tbl_PDIMaster
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("VendorID")]
        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [Column("LotNumber")]
        [StringLength(50)]
        public string? LotNumber { get; set; }

        [Column("Remarks")]
        [StringLength(150)]
        // Consider VARCHAR(500) for Remarks
        public string? Remarks { get; set; }

        [Column("ReportUploadPath")]
        [StringLength(50)]
        // Consider VARCHAR(255) for ReportUploadPath
        public string? ReportUploadPath { get; set; }

        [Column("CreateDate")]
        public DateTime? CreateDate { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }
}