using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QMS.core.Models
{
    public class SPMScoresViewModel
    {
        [Key]
        public int SPM_ID { get; set; }

        [ForeignKey("VendorMaster")]
        public int? VendorID { get; set; }

        [ForeignKey("SPMParameterMaster")]
        public int? ParameterID { get; set; }

        [StringLength(50)]
        // Consider VARCHAR(7) for YYYY-MM format
        public string? Month { get; set; }

        [StringLength(50)]
        // Consider decimal or int for Score
        public string? Score { get; set; }

        [StringLength(50)]
        public string? Remarks { get; set; }

        public DateTime? CreatedDate { get; set; }

       
    }

   
}
