using System;
using System.ComponentModel.DataAnnotations;
using QMS.core.DatabaseContext;
using System.ComponentModel.DataAnnotations.Schema;
using QMS.core.DatabaseContext;
namespace QMS.core.Models
{
   
   public class VendorContactMasterViewModel
    {
        [Key]
        public int VendorContactID { get; set; }

        [StringLength(50)]
        public string? VendorContactName { get; set; }

        [ForeignKey("VendorDesignation")]
        public int? VendorDesignation { get; set; }

        [StringLength(50)]
        public string? VendorMobile { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string? VendorContactEmail { get; set; }

        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? CreateDate { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
        public virtual VendorDesignation? Designation { get; set; }
    }

  
}
