using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QMS.core.DatabaseContext;
namespace QMS.core.Models

{

    public class VendorTypeViewModel
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string? TypeName { get; set; } // Renamed to avoid reserved keyword

        [StringLength(50)]
        // Consider VARCHAR(7) for YYYY-MM format
        public string? Month { get; set; }

        [StringLength(50)]
        // Consider decimal or int for Score
        public string? Score { get; set; }

        [StringLength(150)]
        public string? Remarks { get; set; }

        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        public virtual VendorMaster? Vendor { get; set; }
    }


}

