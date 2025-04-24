using System;
using System.ComponentModel.DataAnnotations;

namespace QMS.core.Models
{
    public class SPMParameterMasterViewModel
    {
        [Key]
        public int ParamID { get; set; }

        [StringLength(50)]
        public string? ParamName { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
