using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_VendorMaster")]
    public class Vendor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorID { get; set; }

        [Required]
        [StringLength(200)]
        public string VendorName { get; set; }

        [StringLength(500)]
        public string? Address { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(15)]
        public string? MobileNumber { get; set; }

        [StringLength(20)]
        public string? GSTNumber { get; set; }

        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [StringLength(100)]
        public string? CreatedBy { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
