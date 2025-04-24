using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_VendorContactMaster")]
    public class VendorContactMaster
    {
        [Key]
        [Column("VendorContactID")]
        public int VendorContactID { get; set; }

        [Column("VendorContactName")]
        [StringLength(100)]
        public string? VendorContactName { get; set; }

        [Column("VendorDesignation")]
        [StringLength(100)]
        public string? VendorDesignation { get; set; }

        [Column("VendorMobile")]
        [StringLength(20)]
        public string? VendorMobile { get; set; }

        [Column("VendorContactEmail")]
        [StringLength(100)]
        [EmailAddress]
        public string? VendorContactEmail { get; set; }

        [Column("VendorID")]
        public int VendorID { get; set; }

        [Column("UpdatedDate")]
        public DateTime? UpdatedDate { get; set; }

        [Column("CreateDate")]
        public DateTime? CreateDate { get; set; }
    }
}
