using QMS.core.DatabaseContext.Shared;
using QMS.core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_ProductMaster")]
    public class ProductMaster : SqlTable
    {
        //-----------------------------------
        // SqlTable override
        //-----------------------------------
        [Key]
        [Column("ProductID")]
        public override int Id { get; set; }

        [Column("IsDeleted")]
        // Note: IsDeleted column does not exist in tbl_ProductMaster
        public override bool Deleted { get; set; }
        //------------ END overrides --------

        [Column("VendorID")]
        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [Column("ProductName")]
        [StringLength(50)]
        public string? ProductName { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }
}