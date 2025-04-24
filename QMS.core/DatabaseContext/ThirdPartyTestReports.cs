using QMS.core.DatabaseContext.Shared;
using QMS.core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_ThirdPartyTestReports")]
    public class ThirdPartyTestReports : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("TestID")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        // Note: IsDeleted column does not exist in tbl_ThirdPartyTestReports
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("VendorID")]
        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [Column("TestName")]
        [StringLength(50)]
        public string? TestName { get; set; }

        [Column("UploadPath")]
        [StringLength(50)]
        // Consider VARCHAR(255) for UploadPath
        public string? UploadPath { get; set; }

        [Column("ReportDate")]
        public DateTime? ReportDate { get; set; }

        [Column("CreateDate")]
        public DateTime? CreateDate { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }
}