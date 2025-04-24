using QMS.core.DatabaseContext.Shared;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_SPMParameterMaster")]
    public class SPMParameterMaster : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("ParamID")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        // Note: IsDeleted column does not exist in tbl_SPMParameterMaster
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("ParamName")]
        [StringLength(50)]
        public string? ParamName { get; set; }

        [Column("Description")]
        [StringLength(50)]
        // Consider VARCHAR(255) for Description
        public string? Description { get; set; }

        [Column("CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        [Column("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }
    }
}