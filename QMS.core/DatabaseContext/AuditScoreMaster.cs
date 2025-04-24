using QMS.core.DatabaseContext.Shared;
using QMS.core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_AuditScoreMaster")]
    public class AuditScoreMaster : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("AuditID")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        // Note: IsDeleted column does not exist in tbl_AuditScoreMaster
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("VendorID")]
        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [Column("Year")]
        [StringLength(50)]
        public string? Year { get; set; }

        [Column("Score")]
        [StringLength(50)]
        public string? Score { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }
}