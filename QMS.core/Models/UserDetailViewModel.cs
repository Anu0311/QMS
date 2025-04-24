using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QMS.core.Models
{
    public class UserDetailViewModel
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? Username { get; set; }

        [StringLength(50)]
        // Use hashed passwords (e.g., VARCHAR(255) in DB)
        public string? Password { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreatedDate { get; set; }
    }

   
}
