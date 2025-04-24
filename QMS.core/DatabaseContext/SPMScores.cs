using QMS.core.DatabaseContext.Shared;
using QMS.core.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_SPMScores")]
    public class SPMScores : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("SPM_ID")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        // Note: IsDeleted column does not exist in tbl_SPMScores
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("VendorID")]
        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [Column("ParameterID")]
        [ForeignKey("SPMParameterMaster")]
        public int? ParameterID { get; set; }

        [Column("Month")]
        [StringLength(50)]
        // Consider VARCHAR(7) for YYYY-MM format
        public string? Month { get; set; }

        [Column("Score")]
        [StringLength(50)]
        // Consider decimal or int for Score
        public string? Score { get; set; }

        [Column("Remarks")]
        [StringLength(50)]
        public string? Remarks { get; set; }

        [Column("CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
        public virtual SPMParameterMaster? Parameter { get; set; }
    }
}