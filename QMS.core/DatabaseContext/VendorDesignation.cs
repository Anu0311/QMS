using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QMS.core.DatabaseContext
{
    [Table("tbl_VendorDesignation")]
    public class VendorDesignation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VendorDesignationID { get; set; }

        [Required]
        [StringLength(100)]
        public string ?VendorDesignationName { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
